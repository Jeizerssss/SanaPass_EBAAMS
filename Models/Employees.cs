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
        public string ePosition { get; set; }

        public Employee()
        {
        }
    }
}
