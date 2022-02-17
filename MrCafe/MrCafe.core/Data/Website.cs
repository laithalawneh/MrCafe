using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MrCafe.Core.Data
{
    public class website
    {
        [Key]
        public int ID { get; set; } 
        public string websitename { get; set; }
        public string aboutus { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int Rate { get; set; }
        public string image1 { get; set; }
        public string image2 { get; set; }
        public string image3 { get; set; }
    }
}
