using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface IRequestService
    {
        IEnumerable<Request> getAllRequests();
        IEnumerable<Request> getRequestsByUserId(int userId);
        bool createRequest(Request request);
        bool approveRequest(int requestId);
        bool rejectRequest(int requestId);
        bool returnEquipment(int requestId);
    }
}
