using System;

namespace SanaPass_EBAAMS.Models
{
    public class PaymentHistory
    {
        public int paymentHistoriesID { get; set; }
        public DateTime pDate { get; set; }
        public int userID { get; set; }
        public string pHType { get; set; }
        public double accountBalance { get; set; }
        public double amountReceived { get; set; }
        public double remainingBalance { get; set; }

        public PaymentHistory()
        {
        }
    }
}
