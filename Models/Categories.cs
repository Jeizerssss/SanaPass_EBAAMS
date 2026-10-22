using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Models
{
    public class Category
    {
        public int categoryID { get; set; }
        public string cName { get; set; }
        public string cDesc { get; set; }

        public Category() { }
        public Category(int categoryID, string cName, string cDesc)
        {
            this.categoryID = categoryID;
            this.cName = cName;
            this.cDesc = cDesc;
        }
    }
}
