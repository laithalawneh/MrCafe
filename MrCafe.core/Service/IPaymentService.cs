using MrCafe.core.DTO;
using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Service
{
    public interface IPaymentService
    {
        public List<payment> GetAllPayments();
        public bool CreatePayment(payment payment);
        public bool UpdatePayment(payment payment);
        public bool DeletePayment(int id);
        public string GetCheckCard(payment card);

        public List<payment> checkbalance(payment pay);
        public bool UpdateBayPayment(PaymentBay payment);
    }
}
