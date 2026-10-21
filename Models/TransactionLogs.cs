using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Models
{
    public class TransactionLog
    {
        public int transactionLogID { get; set; }
        public DateTime date { get; set; }
        public int requestID { get; set; }
        public int handledBy { get; set; }
        public string tlType { get; set; }

        public TransactionLog() { }
    }
}
