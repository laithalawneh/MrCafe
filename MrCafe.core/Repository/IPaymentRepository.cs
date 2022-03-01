using MrCafe.core.DTO;
using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Repository
{
    public interface IPaymentRepository
    {
        public List<payment> GetAllPayments();
        public bool CreatePayment(payment payment);
        public bool UpdatePayment(payment payment);
        public bool DeletePayment(int id);
        public payment GetCheckCard(payment card);

        public List<payment> checkbalance(payment pay);
        public bool UpdateBayPayment(PaymentBay payment);
    }
}
