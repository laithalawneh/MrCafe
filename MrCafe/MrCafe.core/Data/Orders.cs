using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MrCafe.Core.Data
{
    public class Orders
    {
        [Key]
        public int ID { get; set; }
        public int Status { get; set; }
        public DateTime DateofOrder { get; set; }
        public int Userid { get; set; }

        [ForeignKey("Userid")]
        public virtual Users Users { get; set; }

        public virtual ICollection<Cartorder> Cartorders { get; set; }
        public virtual ICollection<productorder> productorders { get; set; }
        public virtual ICollection<deliveryorder> deliveryorders { get; set;}


    }
}
