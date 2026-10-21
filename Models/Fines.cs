using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Models
{
    public class Fine
    {
        public int fineID { get; set; }
        public DateTime date { get; set; }
        public int requestID { get; set; }
        public double amount { get; set; }
        public string fineStatus { get; set; }

        public Fine() { }

        public double calculateFine(int daysOverdue, double dailyRate)
        {
            amount = daysOverdue * dailyRate;
            return amount;
        }
    }
}
