using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Infra.Service
{
    public class OrdersService : IOrdersService
    {
        private readonly IOrdersRepository _ordersRepository;

        public OrdersService(IOrdersRepository ordersService)
        {
            _ordersRepository = ordersService;
        }
        public bool CreateOrders(Orders orders)
        {
            return _ordersRepository.CreateOrder(orders);
        }

        public bool DeleteOrders(int id)
        {
            return _ordersRepository.DeleteOrder(id);
        }

        public List<Orders> GetAllOrderss()
        {
            return _ordersRepository.GetAllOrders();
        }

        public bool UpdateOrders(Orders orders)
        {
            return _ordersRepository.UpdateOrder(orders);
        }
    }
}
