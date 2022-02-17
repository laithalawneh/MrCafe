using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MrCafe.Core.Data;
using MrCafe.Core.Service;
using System.Collections.Generic;

namespace MrCafe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersService _ordersService;

        public OrdersController(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }

        [HttpGet("GetAllOrderss")]
        [ProducesResponseType(typeof(List<Orders>), StatusCodes.Status200OK)]
        public List<Orders> GetAllOrderss()
        {
            return _ordersService.GetAllOrderss();
        }

        [HttpPost("CreateOrders")]
        [ProducesResponseType(typeof(Orders), StatusCodes.Status200OK)]
        public bool CreateOrders([FromBody] Orders orders)
        {
            return _ordersService.CreateOrders(orders);
        }


        [HttpDelete("DeleteOrders/{id}")]
        [ProducesResponseType(typeof(Orders), StatusCodes.Status200OK)]
        public bool DeleteOrders(int id)
        {
            return _ordersService.DeleteOrders(id);
        }


        [HttpPut("UpdateOrders")]
        [ProducesResponseType(typeof(Orders), StatusCodes.Status200OK)]
        public bool UpdateOrders([FromBody] Orders orders)
        {
            return _ordersService.UpdateOrders(orders);
        }
    }
}
