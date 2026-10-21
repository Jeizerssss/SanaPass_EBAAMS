using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface IBorrowService
    {
        bool submitBorrowRequest(int userID, int equipmentID, string rDesc);
        bool approveAndReleaseRequest(int requestID, int handledBy);
        bool processReturn(int requestID, int handledBy, string eCondition, DateTime returnDate);
    }
}
