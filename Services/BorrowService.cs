using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;

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
            _requestRepository = requestRepository
                ?? throw new ArgumentNullException(nameof(requestRepository));

            _equipmentRepository = equipmentRepository
                ?? throw new ArgumentNullException(nameof(equipmentRepository));

            _transactionLogRepository = transactionLogRepository
                ?? throw new ArgumentNullException(nameof(transactionLogRepository));

            _fineService = fineService
                ?? throw new ArgumentNullException(nameof(fineService));

            _maintenanceRepository = maintenanceRepository
                ?? throw new ArgumentNullException(nameof(maintenanceRepository));
        }

        public bool submitBorrowRequest(
            int userID,
            int equipmentID,
            string rLocation,
            string rDesc)
        {
            if (userID <= 0 ||
                equipmentID <= 0 ||
                string.IsNullOrWhiteSpace(rLocation))
            {
                return false;
            }

            var equipment = _equipmentRepository.getById(equipmentID);

            if (equipment == null ||
                !string.Equals(
                    equipment.eStatus,
                    "Available",
                    StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            var request = new Request
            {
                rDate = DateTime.Now,
                userID = userID,
                equipmentID = equipmentID,
                rLocation = rLocation.Trim(),
                rDesc = rDesc,
                rStatus = "Pending Approval"
            };

            return _requestRepository.add(request);
        }

        public bool approveRequest(int requestID, int handledBy)
        {
            if (requestID <= 0 || handledBy <= 0)
            {
                return false;
            }

            var request = _requestRepository.getById(requestID);

            if (request == null ||
                request.rStatus != "Pending Approval")
            {
                return false;
            }

            if (!_requestRepository.updateStatus(
                requestID,
                "Pending Release"))
            {
                return false;
            }

            return _transactionLogRepository.add(new TransactionLog
            {
                tlDate = DateTime.Now,
                requestID = requestID,
                handledBy = handledBy,
                tlType = "REQUEST_APPROVED"
            });
        }

        public bool releaseEquipment(int requestID, int handledBy)
        {
            if (requestID <= 0 || handledBy <= 0)
            {
                return false;
            }

            var request = _requestRepository.getById(requestID);

            if (request == null ||
                request.rStatus != "Pending Release")
            {
                return false;
            }

            var equipment = _equipmentRepository.getById(request.equipmentID);

            if (equipment == null ||
                !string.Equals(
                    equipment.eStatus,
                    "Available",
                    StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            if (!_equipmentRepository.updateStatus(
                equipment.equipmentID,
                "Issued"))
            {
                return false;
            }

            if (!_requestRepository.updateStatus(
                requestID,
                "Pending Return"))
            {
                return false;
            }

            return _transactionLogRepository.add(new TransactionLog
            {
                tlDate = DateTime.Now,
                requestID = requestID,
                handledBy = handledBy,
                tlType = "EQUIPMENT_ISSUED"
            });
        }

        public bool processReturn(
            int requestID,
            int handledBy,
            string eCondition,
            DateTime returnDate)
        {
            if (requestID <= 0 || handledBy <= 0)
            {
                return false;
            }

            var request = _requestRepository.getById(requestID);

            if (request == null ||
                request.rStatus != "Pending Return")
            {
                return false;
            }

            var equipment = _equipmentRepository.getById(request.equipmentID);

            if (equipment == null)
            {
                return false;
            }

            _fineService.calculateOverdueFine(
                requestID,
                returnDate,
                50.0);

            bool damaged = string.Equals(
                eCondition,
                "Damaged",
                StringComparison.OrdinalIgnoreCase);

            string equipmentStatus = damaged
                ? "Under Maintenance"
                : "Available";

            if (!_equipmentRepository.updateStatus(
                equipment.equipmentID,
                equipmentStatus))
            {
                return false;
            }

            if (damaged &&
                !_maintenanceRepository.add(new Maintenance
                {
                    mDate = DateTime.Now,
                    equipmentID = equipment.equipmentID,
                    mStatus = "Under Maintenance",
                    mDesc = $"Item returned damaged from Request #{requestID}."
                }))
            {
                return false;
            }

            if (!_requestRepository.updateStatus(
                requestID,
                "Returned"))
            {
                return false;
            }

            return _transactionLogRepository.add(new TransactionLog
            {
                tlDate = DateTime.Now,
                requestID = requestID,
                handledBy = handledBy,
                tlType = "EQUIPMENT_RETURNED"
            });
        }
    }
}
