using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.core.DTO
{
    public class CartDTO
    {
        public int Id { get; set; }
        public string productname { get; set; }
        public string productdescription { get; set; }
        public decimal? Price { get; set; }
        public int productid { get; set; }
        public int cafeid { get; set; }

        public decimal? quantity { get; set; }
    }
}