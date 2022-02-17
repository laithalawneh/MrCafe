using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Service
{
    public interface ICartService
    {
        public List<Cart> GetAllCarts();
        public bool CreateCart(Cart cart);
        public bool UpdateCart(Cart cart);
        public bool DeleteCart(int id);
        public List<Cart> GetCartByUserId(Cart cart);
        public List<Cart> GetCartById(Cart cart);
    }
}
