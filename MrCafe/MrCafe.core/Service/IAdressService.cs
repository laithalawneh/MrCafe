using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Service
{
    public interface IAdressService
    {
        public List<Adress> GetAllAdresses();
        public bool CreateAdress(Adress adress);
        public bool UpdateAdress(Adress adress);
        public bool DeleteAdress(int id);
    }
}
