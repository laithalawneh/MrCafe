using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Infra.Service
{
    public class CartOrderService : ICartOrderService
    {
        private readonly ICartOrderRepository _cartOrderRepository;

        public CartOrderService(ICartOrderRepository cartOrderService)
        {
            _cartOrderRepository = cartOrderService;
        }
        public bool CreateCartOrder(Cartorder cartOrder)
        {
            return _cartOrderRepository.insertCartorder(cartOrder);
        }

        public bool DeleteCartOrder(int id)
        {
            return _cartOrderRepository.deleteCartorder(id);
        }

        public List<Cartorder> GetAllCartOrders()
        {
            return _cartOrderRepository.getallCartorder();
        }

        public List<Cartorder> GetCartOrderByCartId(Cartorder cartOrder)
        {
            return _cartOrderRepository.getCartorderbyCartid(cartOrder);
        }

        public List<Cartorder> GetCartOrderById(Cartorder cartOrder)
        {
            return _cartOrderRepository.getCartorderbyid(cartOrder);
        }

        public bool UpdateCartOrder(Cartorder cartOrder)
        {
            return _cartOrderRepository.updateCartorder(cartOrder);
        }
    }
}
