using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Infra.Service
{
    public class AdressService : IAdressService
    {
        private readonly IAdressRepository _adressRepository;

        public AdressService(IAdressRepository adressService)
        {
            _adressRepository = adressService;
        }
        public bool CreateAdress(Adress adress)
        {
            return _adressRepository.CreateAdress(adress);
        }

        public bool DeleteAdress(int id)
        {
            return _adressRepository.DeleteAdress(id);
        }

        public List<Adress> GetAllAdresses()
        {
            return _adressRepository.GetAllAdress();
        }

        public bool UpdateAdress(Adress adress)
        {
            return _adressRepository.UpdateAdress(adress);
        }
    }
}
