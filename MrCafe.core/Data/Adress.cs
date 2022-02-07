using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MrCafe.Core.Data
{
    public class Adress
    {
        [Key]
        public int ID { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get;set; }
        public int deliveryid { get; set; }

        [ForeignKey("deliveryid")]
        public virtual delivery delivery { get; set; }
    }
}
