using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface ITransactionLogRepository : IReadOnlyRepository<TransactionLog, int>
    {
        bool add(TransactionLog log);
        IEnumerable<TransactionLog> getByRequestId(int requestID);
        IEnumerable<TransactionLog> getByHandledBy(int handledBy);
    }
}
