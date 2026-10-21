using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Models
{
    public class Equipment
    {
        public int equipmentID { get; set; }
        public string eName { get; set; }
        public string eDesc { get; set; }
        public int categoryID { get; set; }
        public int locationID { get; set; }
        public string eStatus { get; set; }
        public int eQuantity { get; set; }
        public double ePrice { get; set; }
        public string eCondition { get; set; }

        public Equipment() { }

        public bool checkAvailability()
        {
            return eQuantity > 0 && eStatus == "Available";
        }

        public void updateStatus(string newStatus)
        {
            eStatus = newStatus;
        }
    }
}
