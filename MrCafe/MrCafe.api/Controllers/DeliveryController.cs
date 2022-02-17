using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MrCafe.Core.Data;
using MrCafe.Core.Service;
using System.Collections.Generic;

namespace MrCafe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        private readonly IDeliveryService _deliveryService;

        public DeliveryController(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }

        [HttpGet("GetAllDeliverys")]
        [ProducesResponseType(typeof(List<delivery>), StatusCodes.Status200OK)]
        public List<delivery> GetAllDeliverys()
        {
            return _deliveryService.GetAllDeliverys();
        }

        [HttpPost("CreateDelivery")]
        [ProducesResponseType(typeof(delivery), StatusCodes.Status200OK)]
        public bool CreateDelivery([FromBody] delivery delivery)
        {
            return _deliveryService.CreateDelivery(delivery);
        }


        [HttpDelete("DeleteDelivery/{id}")]
        [ProducesResponseType(typeof(delivery), StatusCodes.Status200OK)]
        public bool DeleteDelivery(int id)
        {
            return _deliveryService.DeleteDelivery(id);
        }


        [HttpPut("UpdateDelivery")]
        [ProducesResponseType(typeof(delivery), StatusCodes.Status200OK)]
        public bool UpdateDelivery([FromBody] delivery delivery)
        {
            return _deliveryService.UpdateDelivery(delivery);
        }
    }
}
