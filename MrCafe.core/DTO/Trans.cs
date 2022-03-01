using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.core.DTO
{
    public class Trans
    {
        public int TransID { get; set; }
        public string Transtype { get; set; }
        public double amount { get; set; }
        public int user_id { get; set; }
        public int cafe_id { get; set; }
    }
}
