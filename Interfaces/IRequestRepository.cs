using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface IRequestRepository : ICrudRepository<Request, int>
    {
        IEnumerable<Request> getByUserId(int userID);
        IEnumerable<Request> getByStatus(string rStatus);
        bool updateStatus(int requestID, string rStatus);
    }
}
