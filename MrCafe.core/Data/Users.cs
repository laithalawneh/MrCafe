using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MrCafe.Core.Data
{
    public class Users
    {
        [Key]
        public int Userid { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }
        public double? Salary { get; set; }

        public virtual ICollection<payment> Payment { get; set; }
        public virtual ICollection<testimonial> Testimonial { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Orders> Orders { get; set;}
        public virtual ICollection<Login> Login { get; set; }


    }
}
