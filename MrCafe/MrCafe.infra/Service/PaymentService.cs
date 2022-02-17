using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Infra.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentService)
        {
            _paymentRepository = paymentService;
        }
        public bool CreatePayment(payment payment)
        {
            return _paymentRepository.CreatePayment(payment);
        }

        public bool DeletePayment(int id)
        {
            return _paymentRepository.DeletePayment(id);
        }

        public List<payment> GetAllPayments()
        {
            return _paymentRepository.GetAllPayments();
        }

        public bool UpdatePayment(payment payment)
        {
            return _paymentRepository.UpdatePayment(payment);
        }
    }
}
