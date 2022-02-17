using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Repository
{
    public interface ICafesRepository
    {
        public List<Cafes> GetAllCafes();
        public bool CreateCafes(Cafes cafe);
        public bool UpdateCafes(Cafes cafe);
        public bool DeleteCafes(int id);
        public List<Cafes> GetCafeById(Cafes cafe);
        public List<Cafes> GetCafeByname(string name);
        public List<Cafes> GetCafeByDescendingRate();
        public List<Cafes> GetCafeByRate(Cafes cafe);

    }
}
