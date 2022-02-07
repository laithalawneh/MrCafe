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
    }
}
