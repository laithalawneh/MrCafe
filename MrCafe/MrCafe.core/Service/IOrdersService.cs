using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Service
{
    public interface IOrdersService
    {
        public List<Orders> GetAllOrderss();
        public bool CreateOrders(Orders orders);
        public bool UpdateOrders(Orders orders);
        public bool DeleteOrders(int id);
    }
}
