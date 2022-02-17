using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Infra.Service
{
    public class CountactUsService : ICountactUsService
    {
        private readonly ICountactUsRepository _countactUsRepository;

        public CountactUsService(ICountactUsRepository countactUsService)
        {
            _countactUsRepository = countactUsService;
        }
        public bool CreateCountactUs(contactus countactUs)
        {
            return _countactUsRepository.Createcontactus(countactUs);
        }

        public bool DeleteCountactUs(int id)
        {
            return _countactUsRepository.Deletecontactus(id);
        }

        public List<contactus> GetAllCountactUss()
        {
            return _countactUsRepository.GetAllcontactus();
        }

        public bool UpdateCountactUs(contactus countactUs)
        {
            return _countactUsRepository.Updatecontactus(countactUs);
        }
    }
}
