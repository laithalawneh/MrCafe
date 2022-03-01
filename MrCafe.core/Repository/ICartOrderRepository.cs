using MrCafe.core.DTO;
using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Repository
{
    public interface ICartOrderRepository
    {
        public List<Cartorder> getallCartorder();
        public bool insertCartorder(Cartorder cartOrder);
        public bool updateCartorder(Cartorder cartOrder);
        public bool deleteCartorder(int id);
        public List<Cartorder> getCartorderbyid(Cartorder cartOrder);
        public List<CartDTO> getCartorderbyUserid(Cartorder cartOrder);
    }
}
