using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Repository
{
    public interface IAdressRepository
    {
        public List<Adress> GetAllAdress();
        public bool CreateAdress(Adress adress);
        public bool UpdateAdress(Adress adress);
        public bool DeleteAdress(int id);
    }
}
