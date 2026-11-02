using System;

namespace SanaPass_EBAAMS.Models
{
    public class Request
    {
        public int requestID { get; set; }
        public DateTime rDate { get; set; }
        public int userID { get; set; }
        public int equipmentID { get; set; }
        public string rLocation { get; set; }
        public string rDesc { get; set; }
        public string rStatus { get; set; }

        public Request()
        {
        }
    }
}
