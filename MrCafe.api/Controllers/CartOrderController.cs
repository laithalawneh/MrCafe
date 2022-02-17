using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MrCafe.Core.Data;
using MrCafe.Core.Service;
using System.Collections.Generic;

namespace MrCafe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartOrderController : ControllerBase
    {
        private readonly ICartOrderService _cartOrderService;

        public CartOrderController(ICartOrderService cartOrderService)
        {
            _cartOrderService = cartOrderService;
        }

        [HttpGet("GetAllCartOrders")]
        [ProducesResponseType(typeof(List<Cartorder>), StatusCodes.Status200OK)]
        public List<Cartorder> GetAllCartOrderes()
        {
            return _cartOrderService.GetAllCartOrders();
        }

        [HttpPost("CreateCartOrder")]
        [ProducesResponseType(typeof(Cartorder), StatusCodes.Status200OK)]
        public bool CreateCartOrder([FromBody] Cartorder cartOrder)
        {
            return _cartOrderService.CreateCartOrder(cartOrder);
        }


        [HttpDelete("DeleteCartOrder/{id}")]
        [ProducesResponseType(typeof(Cartorder), StatusCodes.Status200OK)]
        public bool DeleteCartOrder(int id)
        {
            return _cartOrderService.DeleteCartOrder(id);
        }


        [HttpPut("UpdateCartOrder")]
        [ProducesResponseType(typeof(Cartorder), StatusCodes.Status200OK)]
        public bool UpdateCartOrder([FromBody] Cartorder cartOrder)
        {
            return _cartOrderService.UpdateCartOrder(cartOrder);
        }

        [HttpPost("GetCartOrderByCartId")]
        [ProducesResponseType(typeof(Cartorder), StatusCodes.Status200OK)]
        public List<Cartorder> GetCartOrderByCartId([FromBody] Cartorder cartOrder)
        {
            return _cartOrderService.GetCartOrderByCartId(cartOrder);
        }

        [HttpPost("GetCartOrderById")]
        [ProducesResponseType(typeof(Cartorder), StatusCodes.Status200OK)]
        public List<Cartorder> GetCartOrderById([FromBody] Cartorder cartOrder)
        {
            return _cartOrderService.GetCartOrderById(cartOrder);
        }

    }
}
