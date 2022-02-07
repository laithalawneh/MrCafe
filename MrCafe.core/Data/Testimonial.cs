using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MrCafe.Core.Data
{
    public class testimonial
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string testcontent { get; set; }
        public int Status { get; set; }
        public int userid { get; set; }

        [ForeignKey("userid")]
        public virtual Users Users { get; set; }
    }
}
