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
        public bool DeleteCartOrder(int id);
        public List<Cartorder> GetCartOrderById(Cartorder cartOrder);
        public List<Cartorder> GetCartOrderByCartId(Cartorder cartOrder);
    }
}
