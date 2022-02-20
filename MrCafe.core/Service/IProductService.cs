using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Service
{
    public interface IProductService
    {
        public List<product> GetAllProducts();
        public bool CreateProduct(product product);
        public bool UpdateProduct(product product);
        public bool DeleteProduct(int id);
        public List<product> GetAllproductbyCategory(int id);
        public List<product> GetAllproductbyCafe(int id);
    }
}
