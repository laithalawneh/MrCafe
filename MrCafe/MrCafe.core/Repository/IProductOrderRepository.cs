using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Repository
{
    public interface IProductOrderRepository
    {
        public List<productorder> GetAllproductorder();
        public bool Createproductorder(productorder productOrder);
        public bool Updateproductorder(productorder productOrder);
        public bool Deleteproductorder(int id);
    }
}
