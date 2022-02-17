using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MrCafe.Core.Data;
using MrCafe.Core.Service;
using System.Collections.Generic;

namespace MrCafe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet("GetAllCarts")]
        [ProducesResponseType(typeof(List<Cart>), StatusCodes.Status200OK)]
        public List<Cart> GetAllCartes()
        {
            return _cartService.GetAllCarts();
        }

        [HttpPost("CreateCart")]
        [ProducesResponseType(typeof(Cart), StatusCodes.Status200OK)]
        public bool CreateCart([FromBody] Cart cart)
        {
            return _cartService.CreateCart(cart);
        }


        [HttpDelete("DeleteCart/{id}")]
        [ProducesResponseType(typeof(Cart), StatusCodes.Status200OK)]
        public bool DeleteCart(int id)
        {
            return _cartService.DeleteCart(id);
        }


        [HttpPut("UpdateCart")]
        [ProducesResponseType(typeof(Cart), StatusCodes.Status200OK)]
        public bool UpdateCart([FromBody] Cart cart)
        {
            return _cartService.UpdateCart(cart);
        }

        [HttpPost("GetCartById")]
        [ProducesResponseType(typeof(Cart), StatusCodes.Status200OK)]
        public List<Cart> GetCartById([FromBody]Cart cart)
        {
            return _cartService.GetCartById(cart);
        }

        [HttpPost("GetCartByUserId")]
        [ProducesResponseType(typeof(Cart), StatusCodes.Status200OK)]
        public List<Cart> GetCartByUserId([FromBody]Cart cart)
        {
            return _cartService.GetCartByUserId(cart);
        }
    }
}
