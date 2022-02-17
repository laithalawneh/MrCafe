using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Infra.Service
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;

        public CartService(ICartRepository cartService)
        {
            _cartRepository = cartService;
        }
        public bool CreateCart(Cart cart)
        {
            return _cartRepository.insertCart(cart);
        }

        public bool DeleteCart(int id)
        {
            return _cartRepository.deleteCart(id);
        }

        
        public List<Cart> GetAllCarts()
        {
            return _cartRepository.getallCart();
        }

        public List<Cart> GetCartById(Cart cart)
        {
            return _cartRepository.getCartbyid(cart);
        }

        public List<Cart> GetCartByUserId(Cart cart)
        {
            return _cartRepository.getCartbyuserid(cart);
        }

        public bool UpdateCart(Cart cart)
        {
            return _cartRepository.updateCart(cart);
        }
    }
}
