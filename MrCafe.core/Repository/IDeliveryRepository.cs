using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Repository
{
    public interface IDeliveryRepository
    {
        public List<delivery> GetAllDelivery();
        public bool CreateDelivery(delivery delivery);
        public bool UpdateDelivery(delivery delivery);
        public bool DeleteDelivery(int id);
        public double DeliveryOnline();
        public double DeliveryBusy();
    }
}
