using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Models
{
    public class Employee : User
    {
        public int employeeID { get; set; }
        public string position { get; set; }

        public Employee() { }

        public void viewPendingRequests() { }
        public void processApprove() { }
        public void processReject() { }
        public void updateEquipment() { }
        public void fetchPaymentHistories() { }
    }
}
