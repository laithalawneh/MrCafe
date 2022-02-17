using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MrCafe.Core.Data;
using MrCafe.Core.Service;
using System.Collections.Generic;

namespace MrCafe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetAllProducts")]
        [ProducesResponseType(typeof(List<product>), StatusCodes.Status200OK)]
        public List<product> GetAllProducts()
        {
            return _productService.GetAllProducts();
        }

        [HttpPost("CreateProduct")]
        [ProducesResponseType(typeof(product), StatusCodes.Status200OK)]
        public bool CreateProduct([FromBody] product product)
        {
            return _productService.CreateProduct(product);
        }


        [HttpDelete("DeleteProduct/{id}")]
        [ProducesResponseType(typeof(product), StatusCodes.Status200OK)]
        public bool DeleteProduct(int id)
        {
            return _productService.DeleteProduct(id);
        }


        [HttpPut("UpdateProduct")]
        [ProducesResponseType(typeof(product), StatusCodes.Status200OK)]
        public bool UpdateProduct([FromBody] product product)
        {
            return _productService.UpdateProduct(product);
        }

        //[HttpPost("productbyCategory")]
        //public List<product> GetAllproductbyCategory([FromBody] int id)
        //{
        //}

        [HttpGet("productbyCategory/{id}")]
        [ProducesResponseType(typeof(List<product>), StatusCodes.Status200OK)]
        public List<product> GetAllproductbyCategory(int id)
        {
            return _productService.GetAllproductbyCategory(id);
        }
    }
}
