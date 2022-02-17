using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MrCafe.Core.Data
{
    public class Cafes
    {
        [Key]
        public int Cafeid { get; set; }
        public string Cafesname { get; set; }
        public int Rate { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }

        public virtual ICollection<Wallet> Wallets { get; set; }
        public virtual ICollection<product> products { get; set; }
        public virtual ICollection<Login> Logins { get; set; }

    }
}
