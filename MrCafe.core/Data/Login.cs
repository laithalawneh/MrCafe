using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MrCafe.Core.Data
{
    public class Login
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int ?Userid { get; set; }
        public string Rolename { get; set; }
        public int ?Cafeid { get; set; }

        [ForeignKey("Cafeid")]
        public virtual Cafes Cafes { get; set; }

        [ForeignKey("Userid")]
        public virtual Users Users { get; set; }

    }
}
