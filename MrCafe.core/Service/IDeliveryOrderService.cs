using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Service
{
    public interface IDeliveryOrderService
    {
        public List<deliveryorder> GetAllDeliveryOrders();
        public bool CreateDeliveryOrder(deliveryorder deliveryOrder);
        public bool UpdateDeliveryOrder(deliveryorder deliveryOrder);
        public bool DeleteDeliveryOrder(int id);
    }
}
