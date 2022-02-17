using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Service
{
    public interface IDeliveryService
    {
        public List<delivery> GetAllDeliverys();
        public bool CreateDelivery(delivery delivery);
        public bool UpdateDelivery(delivery delivery);
        public bool DeleteDelivery(int id);
    }
}
