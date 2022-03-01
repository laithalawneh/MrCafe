using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MrCafe.Core.Service
{
    public interface ICafesService
    {
        public List<Cafes> GetAllCafes();
        public bool CreateCafes(Cafes cafe);
        public bool UpdateCafes(Cafes cafe);
        public bool DeleteCafes(int id);
        public List<Cafes> GetCofesById(Cafes cafe);
        public List<Cafes> GetCofesByName(string name);
        public List<Cafes> GetCofesByRate(Cafes cafe);
        public List<Cafes> GetCofesByRateDec();
        public Cafes GetCafeId(Cafes cafe);
        public  Task<Cafes> GetAllCafeProducts(int id);
        public List<Cafes> GetTopCafes();
        public List<Cafes> GetCafeByAscendingRate();
    }
}
