using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Repository
{
    public interface ICartRepository
    {
        public List<Cart> getallCart();
        public bool insertCart(Cart cart);
        public bool updateCart(Cart cart);
        public bool deleteCart(int id);
        public List<Cart> getCartbyuserid(Cart cart);
        public List<Cart> getCartbyid(Cart cart);
    }
}
