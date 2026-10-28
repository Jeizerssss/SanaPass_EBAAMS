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

        public RequestService(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
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
            if (request == null || request.userID <= 0 || request.equipmentID <= 0)
                return false;

            request.rStatus = "Pending";
            request.rDate = DateTime.Now;

            return _requestRepository.add(request);
        }

        public bool approveRequest(int requestId)
        {
            return _requestRepository.updateStatus(requestId, "Approved");
        }

        public bool rejectRequest(int requestId)
        {
            return _requestRepository.updateStatus(requestId, "Rejected");
        }

        public bool returnEquipment(int requestId)
        {
            return _requestRepository.updateStatus(requestId, "Returned");
        }
    }
}
