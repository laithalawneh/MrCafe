using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MrCafe.Core.Data
{
    public class Roll
    {
        [Key]
        public int ID { get; set; }
        public string Rollname { get; set; }

        [ForeignKey("Id")]
        public virtual Login Login { get; set; }

        public virtual ICollection<Login> Logins { get; set; }

    }
}
