using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MrCafe.Core.Data
{
    public class payment
    {
        [Key]
        public int ID { get; set; }
        public string serialnumber { get; set; }
        public string password { get; set; }
        public double? Balance { get; set; }
        public int Userid { get; set; }

        [ForeignKey("Userid")]
        public virtual Users Users { get; set; }
        public virtual ICollection<Transactions> Transactions { get;}

    }
}
