using System;

namespace SanaPass_EBAAMS.Models
{
    public class TransactionLog
    {
        public int transactionLogID { get; set; }
        public DateTime tlDate { get; set; }
        public int requestID { get; set; }
        public int handledBy { get; set; }
        public string tlType { get; set; }

        public TransactionLog()
        {
        }
    }
}
