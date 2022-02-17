using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MrCafe.Core.Data
{
    public class Category
    {  
        [Key]
        public int ID { get; set; }
        public string Categoryname { get; set; }

        public virtual ICollection<product> products { get; set;}
    }
}
