using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Models
{
    public class Location
    {
        public int locationID { get; set; }
        public string lName { get; set; }
        public string lDesc { get; set; }
        public int lFloorNo { get; set; }

        public Location() { }
        public Location(int locationID, string lName, string lDesc, int lFloorNo)
        {
            this.locationID = locationID;
            this.lName = lName;
            this.lDesc = lDesc;
            this.lFloorNo = lFloorNo;
        }
    }
}
