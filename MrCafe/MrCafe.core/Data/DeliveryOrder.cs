using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MrCafe.Core.Data
{
    public class deliveryorder
    {
        [Key]   
        public int ID { get; set; }
        public int deliveryid { get; set; }
        public int Orderid { get; set; }

        [ForeignKey("Orderid")]
        public virtual Orders Orders { get; set; }

        [ForeignKey("deliveryid")]
        public virtual delivery delivery { get; set; }
    }
}
