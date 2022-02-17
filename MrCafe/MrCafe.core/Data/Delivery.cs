using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MrCafe.Core.Data
{
    public class delivery
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string phone { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
        public double? Salary { get; set; }

        public virtual ICollection<Adress> Adresses { get; set; }
        public virtual ICollection<deliveryorder> deliveryorders { get; set; }

    }
}
