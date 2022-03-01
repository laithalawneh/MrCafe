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
        public bool deleteCartorder(int id)
        {
            return _cartOrderService.deleteCartorder(id);
        }


        [HttpPut("UpdateCartOrder")]
        [ProducesResponseType(typeof(Cartorder), StatusCodes.Status200OK)]
        public bool UpdateCartOrder([FromBody] Cartorder cartOrder)
        {
            return _cartOrderService.UpdateCartOrder(cartOrder);
        }

        [HttpPost("getCartorderbyUserid")]
        [ProducesResponseType(typeof(CartDTO), StatusCodes.Status200OK)]
        public List<CartDTO> getCartorderbyUserid([FromBody] Cartorder cartOrder)
        {
            return _cartOrderService.getCartorderbyUserid(cartOrder);
        }

        [HttpPost("GetCartOrderById")]
        [ProducesResponseType(typeof(Cartorder), StatusCodes.Status200OK)]
        public List<Cartorder> GetCartOrderById([FromBody] Cartorder cartOrder)
        {
            return _cartOrderService.GetCartOrderById(cartOrder);
        }

    }
}