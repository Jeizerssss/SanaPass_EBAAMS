using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;

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
            _requestRepository =
                requestRepository
                ?? throw new ArgumentNullException(nameof(requestRepository));

            _equipmentRepository = equipmentRepository;
        }

        public IEnumerable<Request> getAllRequests()
        {
            return _requestRepository.getAll();
        }

        public IEnumerable<Request> getRequestsByUserId(int userId)
        {
            if (userId <= 0)
            {
                return new List<Request>();
            }

            return _requestRepository.getByUserId(userId);
        }

        public bool createRequest(Request request)
        {
            if (request == null ||
                request.userID <= 0 ||
                request.equipmentID <= 0 ||
                string.IsNullOrWhiteSpace(request.rLocation))
            {
                return false;
            }

            if (_equipmentRepository != null)
            {
                Equipment equipment =
                    _equipmentRepository.getById(request.equipmentID);

                if (equipment == null ||
                    !IsStatus(equipment.eStatus, "Available"))
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
            if (requestId <= 0)
            {
                return false;
            }

            Request request =
                _requestRepository.getById(requestId);

            if (request == null ||
                (!IsStatus(request.rStatus, "Pending") &&
                 !IsStatus(request.rStatus, "Pending Approval")))
            {
                return false;
            }

            if (_equipmentRepository == null)
            {
                return _requestRepository.updateStatus(
                    requestId,
                    "Approved");
            }

            Equipment equipment =
                _equipmentRepository.getById(request.equipmentID);

            if (equipment == null ||
                !IsStatus(equipment.eStatus, "Available") ||
                !_equipmentRepository.updateStatus(
                    equipment.equipmentID,
                    "Issued"))
            {
                return false;
            }

            if (_requestRepository.updateStatus(
                requestId,
                "Pending Return"))
            {
                return true;
            }

            _equipmentRepository.updateStatus(
                equipment.equipmentID,
                "Available");

            return false;
        }

        public bool returnEquipment(int requestId)
        {
            if (requestId <= 0)
            {
                return false;
            }

            Request request =
                _requestRepository.getById(requestId);

            if (request == null ||
                (!IsStatus(request.rStatus, "Pending Return") &&
                 !IsStatus(request.rStatus, "Issued")))
            {
                return false;
            }

            Equipment equipment = null;

            if (_equipmentRepository != null)
            {
                equipment =
                    _equipmentRepository.getById(request.equipmentID);

                if (equipment == null ||
                    !_equipmentRepository.updateStatus(
                        equipment.equipmentID,
                        "Available"))
                {
                    return false;
                }
            }

            if (_requestRepository.updateStatus(
                requestId,
                "Returned"))
            {
                return true;
            }

            if (equipment != null)
            {
                _equipmentRepository.updateStatus(
                    equipment.equipmentID,
                    "Issued");
            }

            return false;
        }

        public bool cancelRequest(int requestId, int userId)
        {
            if (requestId <= 0 || userId <= 0)
            {
                return false;
            }

            Request request =
                _requestRepository.getById(requestId);

            if (request == null ||
                request.userID != userId)
            {
                return false;
            }

            bool canCancel =
                IsStatus(request.rStatus, "Pending") ||
                IsStatus(request.rStatus, "Pending Approval") ||
                IsStatus(request.rStatus, "Pending Release");

            if (!canCancel)
            {
                return false;
            }

            return _requestRepository.updateStatus(
                requestId,
                "Cancelled");
        }

        private static bool IsStatus(
            string actualStatus,
            string expectedStatus)
        {
            return string.Equals(
                actualStatus,
                expectedStatus,
                StringComparison.OrdinalIgnoreCase);
        }
    }
}
