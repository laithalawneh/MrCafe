using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Service
{
    public interface IWebsiteService
    {
        public List<website> GetAllWebsites();
        public bool CreateWebsite(website website);
        public bool UpdateWebsite(website website);
        public bool DeleteWebsite(int id);
        public List<website> websiteDetails(int id);

    }
}
