using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MrCafe.Core.Data
{
    public class productorder
    {
        [Key]
        public int ID { get; set; }
        public int productid { get; set; }
        public int Orderid { get; set; }
        public int quantity { get; set; }

        [ForeignKey("productid")]
        public virtual product Product { get; set; }

        [ForeignKey("Orderid")]
        public virtual Orders Orders { get; set; }
    }
}
