using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Repository
{
    public interface IDeliveryOrderRepository
    {
        public List<deliveryorder> GetAlldeliveryorder();
        public bool Createdeliveryorder(deliveryorder deliveryOrder);
        public bool Updatedeliveryorder(deliveryorder deliveryOrder);
        public bool Deletedeliveryorder(int id);
    }
}
