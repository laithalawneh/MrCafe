using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Service
{
    public interface IProductOrderService
    {
        public List<productorder> GetAllProductOrders();
        public bool CreateProductOrder(productorder productOrder);
        public bool UpdateProductOrder(productorder productOrder);
        public bool DeleteProductOrder(int id);
    }
}
