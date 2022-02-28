using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Repository
{
    public interface IWebsiteRepository
    {
        public List<website> GetAllwebsite();
        public bool Createwebsite(website website);
        public bool Updatewebsite(website website);
        public bool Deletewebsite(int id);
        public List<website> websiteDetails(int id);

    }
}
