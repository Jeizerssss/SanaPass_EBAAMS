using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Models
{
    public class Maintenance
    {
        public int mID { get; set; }
        public DateTime date { get; set; }
        public int equipmentID { get; set; }
        public string mStatus { get; set; }
        public string mDesc { get; set; }

        public Maintenance() { }
    }
}
