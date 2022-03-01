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
        public int Userid { get; set; }
        public int Productid { get; set; }
        public decimal? Quantity { get; set; }


        [ForeignKey("Userid")]
        public virtual Users User { get; set; }

        [ForeignKey("Productid")]
        public virtual product Product { get; set; }
    }
}
