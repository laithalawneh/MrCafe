using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.core.DTO
{
    public class UserLoginDto
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public decimal salary { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int userId { get; set; }
        public string Rolename { get; set; }
        public int CafeId { get; set; }

    }
}
