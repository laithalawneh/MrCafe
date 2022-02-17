using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MrCafe.Core.Data
{
    public class Wallet
    {
        [Key]
        public int ID { get; set; }
        public int Balance { get; set; }
        public int Cafeid { get; set; }

        [ForeignKey("Cafeid")]
        public virtual Cafes Cafes { get; set; }


    }
}
