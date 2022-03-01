using Microsoft.IdentityModel.Tokens;
using MrCafe.core.DTO;
using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
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

        public string GetCheckCard(payment card)
        {
            var result = _paymentRepository.GetCheckCard(card);

            if (result == null)
            {
                return null;
            }
            else
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.ASCII.GetBytes("[SECRET Used To Sign And Verify Jwt Token, It can be any string]");
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(
                new Claim[]
                {
                      new Claim(ClaimTypes.Name, result.serialnumber),
                      new Claim(ClaimTypes.Role, result.password)

                }
                ),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
        }

        public bool UpdateBayPayment(PaymentBay payment)
        {
            return _paymentRepository.UpdateBayPayment(payment);
        }

        public List<payment> checkbalance(payment pay)
        {
            return _paymentRepository.checkbalance(pay);
        }
    }
}
