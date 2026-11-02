using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Services
{
    public class RequestService : IRequestService
    {
        private readonly IRequestRepository _requestRepository;
        private readonly IEquipmentRepository _equipmentRepository;

        public RequestService(
            IRequestRepository requestRepository,
            IEquipmentRepository equipmentRepository = null)
        {
            _requestRepository = requestRepository
                ?? throw new ArgumentNullException(nameof(requestRepository));
            _equipmentRepository = equipmentRepository;
        }

        public IEnumerable<Request> getAllRequests()
        {
            return _requestRepository.getAll();
        }

        public IEnumerable<Request> getRequestsByUserId(int userId)
        {
            return _requestRepository.getByUserId(userId);
        }

        public bool createRequest(Request request)
        {
            if (request == null || request.userID <= 0 || request.equipmentID <= 0 ||
                string.IsNullOrWhiteSpace(request.rLocation))
                return false;

            if (_equipmentRepository != null)
            {
                var equipment = _equipmentRepository.getById(request.equipmentID);
                if (equipment == null ||
                    !string.Equals(equipment.eStatus, "Available", StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }

            request.rStatus = "Pending";
            request.rDate = DateTime.Now;

            return _requestRepository.add(request);
        }

        public bool approveRequest(int requestId)
        {
            if (_equipmentRepository == null)
            {
                return _requestRepository.updateStatus(requestId, "Approved");
            }

            var request = _requestRepository.getById(requestId);
            if (request == null ||
                (request.rStatus != "Pending" && request.rStatus != "Pending Approval"))
            {
                return false;
            }

            var equipment = _equipmentRepository.getById(request.equipmentID);
            if (equipment == null ||
                !string.Equals(equipment.eStatus, "Available", StringComparison.OrdinalIgnoreCase) ||
                !_equipmentRepository.updateStatus(equipment.equipmentID, "Issued"))
            {
                return false;
            }

            if (_requestRepository.updateStatus(requestId, "Pending Return"))
            {
                return true;
            }

            _equipmentRepository.updateStatus(equipment.equipmentID, "Available");
            return false;
        }

        public bool rejectRequest(int requestId)
        {
            return _requestRepository.updateStatus(requestId, "Rejected");
        }

        public bool returnEquipment(int requestId)
        {
            var request = _requestRepository.getById(requestId);
            if (request == null ||
                (request.rStatus != "Pending Return" && request.rStatus != "Issued"))
            {
                return false;
            }

            var equipment = _equipmentRepository?.getById(request.equipmentID);
            if (_equipmentRepository != null)
            {
                if (equipment == null ||
                    !_equipmentRepository.updateStatus(equipment.equipmentID, "Available"))
                {
                    return false;
                }
            }

            if (_requestRepository.updateStatus(requestId, "Returned"))
            {
                return true;
            }

            if (equipment != null)
            {
                _equipmentRepository.updateStatus(equipment.equipmentID, "Issued");
            }

            return false;
        }
    }
}
