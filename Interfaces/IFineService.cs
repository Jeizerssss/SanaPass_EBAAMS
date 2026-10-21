using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface IFineService
    {
        double calculateOverdueFine(int requestID, DateTime returnDate, double dailyRate);
        bool processFinePayment(int requestID, double amountReceived, string pType, int handledBy);
    }
}
