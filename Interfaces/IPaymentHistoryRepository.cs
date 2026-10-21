using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface IPaymentHistoryRepository : IReadOnlyRepository<PaymentHistory, int>
    {
        bool add(PaymentHistory paymentHistory);
        IEnumerable<PaymentHistory> getByRequestId(int requestID);
    }
}
