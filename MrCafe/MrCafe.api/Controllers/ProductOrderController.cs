using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MrCafe.Core.Data;
using MrCafe.Core.Service;
using System.Collections.Generic;

namespace MrCafe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductOrderController : ControllerBase
    {
        private readonly IProductOrderService _productOrderService;

        public ProductOrderController(IProductOrderService productOrderService)
        {
            _productOrderService = productOrderService;
        }

        [HttpGet("GetAllProductOrders")]
        [ProducesResponseType(typeof(List<productorder>), StatusCodes.Status200OK)]
        public List<productorder> GetAllProductOrders()
        {
            return _productOrderService.GetAllProductOrders();
        }

        [HttpPost("CreateProductOrder")]
        [ProducesResponseType(typeof(productorder), StatusCodes.Status200OK)]
        public bool CreateProductOrder([FromBody] productorder productOrder)
        {
            return _productOrderService.CreateProductOrder(productOrder);
        }


        [HttpDelete("DeleteProductOrder/{id}")]
        [ProducesResponseType(typeof(productorder), StatusCodes.Status200OK)]
        public bool DeleteProductOrder(int id)
        {
            return _productOrderService.DeleteProductOrder(id);
        }


        [HttpPut("UpdateProductOrder")]
        [ProducesResponseType(typeof(productorder), StatusCodes.Status200OK)]
        public bool UpdateProductOrder([FromBody] productorder productOrder)
        {
            return _productOrderService.UpdateProductOrder(productOrder);
        }
    }
}
