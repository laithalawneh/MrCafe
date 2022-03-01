using MrCafe.core.DTO;
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


            List<CartDTO> cartorder = _cartOrderRepository.getCartorderbyUserid(cartOrder);
            if (cartorder.Count == 0)
                return _cartOrderRepository.insertCartorder(cartOrder);

            foreach (CartDTO cartorderitem in cartorder)
            {
                if (cartorderitem.productid == cartOrder.Productid)
                {
                    cartOrder.ID = cartorderitem.Id;
                    cartOrder.Quantity = cartorderitem.quantity + cartOrder.Quantity;
                    return _cartOrderRepository.updateCartorder(cartOrder);
                }
            }

            return _cartOrderRepository.insertCartorder(cartOrder);
        }

        public bool deleteCartorder(int id)
        {
            return _cartOrderRepository.deleteCartorder(id);
        }

        public List<Cartorder> GetAllCartOrders()
        {
            return _cartOrderRepository.getallCartorder();
        }

        public List<CartDTO> getCartorderbyUserid(Cartorder cartOrder)
        {
            return _cartOrderRepository.getCartorderbyUserid(cartOrder);
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