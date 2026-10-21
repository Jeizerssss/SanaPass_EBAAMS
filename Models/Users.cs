using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Models
{
    public class User
    {
        public int userID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string uLName { get; set; }
        public string uFName { get; set; }
        public string uMName { get; set; }
        public string uEmail { get; set; }
        public string uContactNumber { get; set; }
        public string uRole { get; set; }

        public User() { }

        public bool login()
        {
            return true;
        }

        public void logout() { }
        public void updateProfile() { }
    }
}
