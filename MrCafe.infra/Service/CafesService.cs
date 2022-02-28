using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Infra.Service
{
    public class CafesService : ICafesService
    {
        private readonly ICafesRepository _cafesRepository;

        public CafesService(ICafesRepository cafesService)
        {
            _cafesRepository = cafesService;
        }
        public bool CreateCafes(Cafes cafes)
        {
            return _cafesRepository.CreateCafes(cafes);
        }

        public bool DeleteCafes(int id)
        {
            return _cafesRepository.DeleteCafes(id);
        }

        public List<Cafes> GetAllCafes()
        {
            return _cafesRepository.GetAllCafes();
        }

        public List<Cafes> GetCofesById(Cafes cafe)
        {
            return _cafesRepository.GetCafeById(cafe);
        }

        public List<Cafes> GetCofesByName(string name)
        {
            return _cafesRepository.GetCafeByname(name);
        }

        public List<Cafes> GetCofesByRate(Cafes cafe)
        {
            return _cafesRepository.GetCafeByRate(cafe);
        }

        public List<Cafes> GetCofesByRateDec()
        {
            return _cafesRepository.GetCafeByDescendingRate();
        }

        public bool UpdateCafes(Cafes cafes)
        {
            return _cafesRepository.UpdateCafes(cafes);
        }

        public Cafes GetCafeId(Cafes cafe)
        {
            return _cafesRepository.GetCafeId(cafe);
        }
    }
}
