using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MrCafe.Core.Data
{
    public class contactus
    {

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
       public string SUBJECT { get; set; }

      public string senderemail { get; set; }

        public string receiveremail { get; set; }
        public string message { get; set; }

    }
}
