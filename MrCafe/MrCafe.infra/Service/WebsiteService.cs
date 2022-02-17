using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Infra.Repository
{
    public class WebsiteService : IWebsiteService
    {
        private readonly IWebsiteRepository _websiteRepository;

        public WebsiteService(IWebsiteRepository websiteRepository)
        {
            _websiteRepository = websiteRepository;
        }
        public bool CreateWebsite(website website)
        {
            return _websiteRepository.Createwebsite(website);
        }

        public bool DeleteWebsite(int id)
        {
            return _websiteRepository.Deletewebsite(id);
        }

        public List<website> GetAllWebsites()
        {
            return _websiteRepository.GetAllwebsite();
        }


        public bool UpdateWebsite(website website)
        {
            return _websiteRepository.Updatewebsite(website);
        }
    }
}
