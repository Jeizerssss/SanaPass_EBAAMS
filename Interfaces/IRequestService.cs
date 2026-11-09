using SanaPass_EBAAMS.Models;
using System.Collections.Generic;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface IRequestService
    {
        IEnumerable<Request> getAllRequests();
        IEnumerable<Request> getRequestsByUserId(int userId);
        bool createRequest(Request request);
        bool approveRequest(int requestId);
        bool returnEquipment(int requestId);
        bool cancelRequest(int requestId, int userId);
    }
}
