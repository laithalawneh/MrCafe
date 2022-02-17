using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Repository
{
    public interface IProductRepository
    {
        public List<product> GetAllproduct();
        public bool Createproduct(product product);
        public bool Updateproduct(product product);
        public bool Deleteproduct(int id);
        public List<product> GetAllproductbyCategory(int id);
    }
}
