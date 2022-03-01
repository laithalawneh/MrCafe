using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MrCafe.core.DTO;
using MrCafe.Core.Data;
using MrCafe.Core.Service;
using System.Collections.Generic;

namespace MrCafe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet("GetAllPayments")]
        [ProducesResponseType(typeof(List<payment>), StatusCodes.Status200OK)]
        public List<payment> GetAllPayments()
        {
            return _paymentService.GetAllPayments();
        }

        [HttpPost("CreatePayment")]
        [ProducesResponseType(typeof(payment), StatusCodes.Status200OK)]
        public bool CreatePayment([FromBody] payment payment)
        {
            return _paymentService.CreatePayment(payment);
        }


        [HttpDelete("DeletePayment/{id}")]
        [ProducesResponseType(typeof(payment), StatusCodes.Status200OK)]
        public bool DeletePayment(int id)
        {
            return _paymentService.DeletePayment(id);
        }


        [HttpPut("UpdatePayment")]
        [ProducesResponseType(typeof(payment), StatusCodes.Status200OK)]
        public bool UpdatePayment([FromBody] payment payment)
        {
            return _paymentService.UpdatePayment(payment);
        }

        [HttpPut("UpdateBayPayment")]
        [ProducesResponseType(typeof(payment), StatusCodes.Status200OK)]
        public bool UpdateBayPayment([FromBody] PaymentBay payment)
        {
            return _paymentService.UpdateBayPayment(payment);
        }


        [HttpPost("getcheckcard")]
        [ProducesResponseType(typeof(Login), StatusCodes.Status200OK)]
        public IActionResult GetCheckCard([FromBody] payment card)
        {
            var item = _paymentService.GetCheckCard(card);
            if (item == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(item);
            }
        }

        [HttpPost("checkbalance")]
        [ProducesResponseType(typeof(payment), StatusCodes.Status200OK)]
        public List<payment> CheckBalance([FromBody] payment pay)
        {
            return _paymentService.checkbalance(pay);
        }
    }
}
