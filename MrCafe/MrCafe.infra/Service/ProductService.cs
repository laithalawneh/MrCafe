using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Infra.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productService)
        {
            _productRepository = productService;
        }
        public bool CreateProduct(product product)
        {
            return _productRepository.Createproduct(product);
        }

        public bool DeleteProduct(int id)
        {
            return _productRepository.Deleteproduct(id);
        }

        public List<product> GetAllProducts()
        {
            return _productRepository.GetAllproduct();
        }

        public bool UpdateProduct(product product)
        {
            return _productRepository.Updateproduct(product);
        }
    }
}
