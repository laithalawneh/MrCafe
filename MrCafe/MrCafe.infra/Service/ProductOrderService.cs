using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Infra.Service
{
    public class ProductOrderService : IProductOrderService
    {
        private readonly IProductOrderRepository _productOrderRepository;

        public ProductOrderService(IProductOrderRepository productOrderService)
        {
            _productOrderRepository = productOrderService;
        }
        public bool CreateProductOrder(productorder productOrder)
        {
            return _productOrderRepository.Createproductorder(productOrder);
        }

        public bool DeleteProductOrder(int id)
        {
            return _productOrderRepository.Deleteproductorder(id);
        }

        public List<productorder> GetAllProductOrders()
        {
            return _productOrderRepository.GetAllproductorder();
        }

        public bool UpdateProductOrder(productorder productOrder)
        {
            return _productOrderRepository.Updateproductorder(productOrder);
        }
    }
}
