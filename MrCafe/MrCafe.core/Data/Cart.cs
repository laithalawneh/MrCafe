using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MrCafe.Core.Data
{
    public class Cart
    {
        [Key]
        public int ID { get; set; }
        public int Userid { get; set; }

        [ForeignKey("UserId")]
        public virtual Users Users { get; set; }

        public virtual ICollection<Cartorder> Cartorders { get; set;}

    }
}
