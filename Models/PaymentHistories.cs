using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Models
{
    public class PaymentHistory
    {
        public int pHID { get; set; }
        public int requestID { get; set; }
        public string pType { get; set; }
        public double amountReceived { get; set; }
        public double remainingBalance { get; set; }

        public PaymentHistory() { }
    }
}
