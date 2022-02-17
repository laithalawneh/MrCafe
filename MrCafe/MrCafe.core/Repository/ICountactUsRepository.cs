using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Repository
{
    public interface ICountactUsRepository
    {
        public List<contactus> GetAllcontactus();
        public bool Createcontactus(contactus countactUs);
        public bool Updatecontactus(contactus countactUs);
        public bool Deletecontactus(int id);
    }
}
