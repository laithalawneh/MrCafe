using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MrCafe.Core.Data
{
    public class Cartorder
    {
        [Key]
        public int ID { get; set; }
        public int Cartid { get; set;}
        public int Orderid { get; set; }

        [ForeignKey("Cartid")]
        public virtual Cart Cart { get; set; }

        [ForeignKey("Orderid")]
        public virtual Orders Orders { get; set; }
    }
}
