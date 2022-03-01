using MrCafe.core.DTO;
using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Service
{
    public interface ICartOrderService
    {
        public List<Cartorder> GetAllCartOrders();
        public bool CreateCartOrder(Cartorder cartOrder);
        public bool UpdateCartOrder(Cartorder cartOrder);
        public bool deleteCartorder(int id);
        public List<Cartorder> GetCartOrderById(Cartorder cartOrder);
        public List<CartDTO> getCartorderbyUserid(Cartorder cartOrder);
    }
}
