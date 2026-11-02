using SanaPass_EBAAMS.Models;
using System.Collections.Generic;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface IPaymentHistoryRepository : IReadOnlyRepository<PaymentHistory, int>
    {
        bool add(PaymentHistory paymentHistory);
        IEnumerable<PaymentHistory> getByUserId(int userID);
    }
}
