using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MrCafe.Core.Data
{
    public class product
    {
        [Key]
        public int ID { get; set; }
        public string productname { get; set; }
        public string prodescription { get; set; }
        public string Imagename { get; set; }
        public int Rate { get; set; }
        public double price { get; set; }
        public int Categoryid { get; set; }
        public int Cafeid { get; set; }

        [ForeignKey("Categoryid")]
        public virtual Category  Category { get; set; }

        [ForeignKey("Cafeid")]
        public virtual Cafes Cafes { get; set; }
    }
}
