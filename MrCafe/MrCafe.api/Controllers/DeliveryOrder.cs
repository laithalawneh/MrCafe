using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MrCafe.Core.Data;
using MrCafe.Core.Service;
using System.Collections.Generic;

namespace MrCafe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryOrderController : Controller
    {
        private readonly IDeliveryOrderService _deliveryOrderService;

        public DeliveryOrderController(IDeliveryOrderService deliveryOrderService)
        {
            _deliveryOrderService = deliveryOrderService;
        }

        [HttpGet("GetAllDeliveryOrders")]
        [ProducesResponseType(typeof(List<deliveryorder>), StatusCodes.Status200OK)]
        public List<deliveryorder> GetAllDeliveryOrders()
        {
            return _deliveryOrderService.GetAllDeliveryOrders();
        }

        [HttpPost("CreateDeliveryOrder")]
        [ProducesResponseType(typeof(deliveryorder), StatusCodes.Status200OK)]
        public bool CreateDeliveryOrder([FromBody] deliveryorder deliveryOrder)
        {
            return _deliveryOrderService.CreateDeliveryOrder(deliveryOrder);
        }


        [HttpDelete("DeleteDeliveryOrder/{id}")]
        [ProducesResponseType(typeof(deliveryorder), StatusCodes.Status200OK)]
        public bool DeleteDeliveryOrder(int id)
        {
            return _deliveryOrderService.DeleteDeliveryOrder(id);
        }


        [HttpPut("UpdateDeliveryOrder")]
        [ProducesResponseType(typeof(deliveryorder), StatusCodes.Status200OK)]
        public bool UpdateDeliveryOrder([FromBody] deliveryorder deliveryOrder)
        {
            return _deliveryOrderService.UpdateDeliveryOrder(deliveryOrder);
        }

        
    }
}
