using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Services
{
    public class BorrowService : IBorrowService
    {
        private readonly IRequestRepository _requestRepository;
        private readonly IEquipmentRepository _equipmentRepository;
        private readonly ITransactionLogRepository _transactionLogRepository;
        private readonly IFineService _fineService;
        private readonly IMaintenanceRepository _maintenanceRepository;

        public BorrowService(
            IRequestRepository requestRepository,
            IEquipmentRepository equipmentRepository,
            ITransactionLogRepository transactionLogRepository,
            IFineService fineService,
            IMaintenanceRepository maintenanceRepository)
        {
            _requestRepository = requestRepository ?? throw new ArgumentNullException(nameof(requestRepository));
            _equipmentRepository = equipmentRepository ?? throw new ArgumentNullException(nameof(equipmentRepository));
            _transactionLogRepository = transactionLogRepository ?? throw new ArgumentNullException(nameof(transactionLogRepository));
            _fineService = fineService ?? throw new ArgumentNullException(nameof(fineService));
            _maintenanceRepository = maintenanceRepository ?? throw new ArgumentNullException(nameof(maintenanceRepository));
        }

        public bool submitBorrowRequest(int userID, int equipmentID, string rDesc)
        {
            var equipment = _equipmentRepository.getById(equipmentID);
            if (equipment == null || !equipment.checkAvailability())
            {
                return false;
            }

            var request = new Request
            {
                date = DateTime.Now,
                userID = userID,
                equipmentID = equipmentID,
                rDesc = rDesc,
                rStatus = "Pending"
            };

            return _requestRepository.add(request);
        }

        public bool approveAndReleaseRequest(int requestID, int handledBy)
        {
            var request = _requestRepository.getById(requestID);
            if (request == null || request.rStatus != "Pending")
            {
                return false;
            }

            var equipment = _equipmentRepository.getById(request.equipmentID);
            if (equipment == null || equipment.eQuantity <= 0)
            {
                return false;
            }

            // Update Request and Equipment status
            _requestRepository.updateStatus(requestID, "Issued");
            _equipmentRepository.updateQuantity(equipment.equipmentID, equipment.eQuantity - 1);

            if (equipment.eQuantity - 1 == 0)
            {
                _equipmentRepository.updateStatus(equipment.equipmentID, "Unavailable");
            }

            // Log Transaction
            var log = new TransactionLog
            {
                date = DateTime.Now,
                requestID = requestID,
                handledBy = handledBy,
                tlType = "EQUIPMENT_ISSUED"
            };
            _transactionLogRepository.add(log);

            return true;
        }

        public bool processReturn(int requestID, int handledBy, string eCondition, DateTime returnDate)
        {
            var request = _requestRepository.getById(requestID);
            if (request == null || request.rStatus != "Issued")
            {
                return false;
            }

            var equipment = _equipmentRepository.getById(request.equipmentID);
            if (equipment == null)
            {
                return false;
            }

            // 1. Calculate Overdue Fine if applicable
            _fineService.calculateOverdueFine(requestID, returnDate, dailyRate: 50.0);

            // 2. Increment Equipment Inventory Quantity
            _equipmentRepository.updateQuantity(equipment.equipmentID, equipment.eQuantity + 1);
            if (equipment.eStatus == "Unavailable")
            {
                _equipmentRepository.updateStatus(equipment.equipmentID, "Available");
            }

            // 3. Flag Equipment Maintenance if returned damaged
            if (eCondition.Equals("Damaged", StringComparison.OrdinalIgnoreCase))
            {
                _maintenanceRepository.add(new Maintenance
                {
                    date = DateTime.Now,
                    equipmentID = equipment.equipmentID,
                    mStatus = "Under Maintenance",
                    mDesc = $"Item returned damaged from Request #{requestID}."
                });
                _equipmentRepository.updateStatus(equipment.equipmentID, "Under Maintenance");
            }

            // 4. Update Request Status and Audit Log
            _requestRepository.updateStatus(requestID, "Returned");

            _transactionLogRepository.add(new TransactionLog
            {
                date = DateTime.Now,
                requestID = requestID,
                handledBy = handledBy,
                tlType = "EQUIPMENT_RETURNED"
            });

            return true;
        }
    }
}
