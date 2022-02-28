using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Infra.Service
{
    public class DeliveryService : IDeliveryService
    {
        private readonly IDeliveryRepository _deliveryRepository;

        public DeliveryService(IDeliveryRepository deliveryService)
        {
            _deliveryRepository = deliveryService;
        }
        public bool CreateDelivery(delivery delivery)
        {
            return _deliveryRepository.CreateDelivery(delivery);   
        }

        public bool DeleteDelivery(int id)
        {
            return _deliveryRepository.DeleteDelivery(id);
        }

        public List<delivery> GetAllDeliverys()
        {
           return _deliveryRepository.GetAllDelivery();
        }

        public bool UpdateDelivery(delivery delivery)
        {
            return _deliveryRepository.UpdateDelivery(delivery);
        }

        public double DeliveryOnline()
        {
            return _deliveryRepository.DeliveryOnline();
        }
        public double DeliveryBusy()
        {
            return _deliveryRepository.DeliveryBusy();
        }
    }
}
