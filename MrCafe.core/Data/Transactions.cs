using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MrCafe.Core.Data
{
    public class Transactions
    {
        [Key]
        public int TransID { get; set; }
        public string Transtype { get; set; }
        public double amount { get; set; }
        public int paymentid { get; set; }
        public int Walletid { get; set; }

        [ForeignKey("Walletid")]
        public virtual Wallet Wallet { get; set; }

        [ForeignKey("paymentid")]
        public virtual payment payment { get; set; }

    }
}
