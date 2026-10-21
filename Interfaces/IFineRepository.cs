using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface IFineRepository : ICrudRepository<Fine, int>
    {
        Fine getByRequestId(int requestID);
        IEnumerable<Fine> getByStatus(string fineStatus);
        bool updateStatus(int fineID, string fineStatus);
    }
}
