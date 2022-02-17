using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Repository
{
    public interface IOrdersRepository
    {
        public List<Orders> GetAllOrders();
        public bool CreateOrder(Orders orders);
        public bool UpdateOrder(Orders orders);
        public bool DeleteOrder(int id);
    }
}
