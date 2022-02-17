using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Infra.Service
{
    public class DeliveryOrderService : IDeliveryOrderService
    {
        private readonly IDeliveryOrderRepository _deliveryOrderRepository;

        public DeliveryOrderService(IDeliveryOrderRepository deliveryOrderService)
        {
            _deliveryOrderRepository = deliveryOrderService;
        }
        public bool CreateDeliveryOrder(deliveryorder deliveryOrder)
        {
            return _deliveryOrderRepository.Createdeliveryorder(deliveryOrder);
        }

        public bool DeleteDeliveryOrder(int id)
        {
            return _deliveryOrderRepository.Deletedeliveryorder(id);
        }

        public List<deliveryorder> GetAllDeliveryOrders()
        {
            return _deliveryOrderRepository.GetAlldeliveryorder();
        }

        public bool UpdateDeliveryOrder(deliveryorder deliveryOrder)
        {
            return _deliveryOrderRepository.Updatedeliveryorder(deliveryOrder);
        }
    }
}
