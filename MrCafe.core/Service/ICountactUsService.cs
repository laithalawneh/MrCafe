using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Service
{
    public interface ICountactUsService
    {
        public List<contactus> GetAllCountactUss();
        public bool CreateCountactUs(contactus countactUs);
        public bool UpdateCountactUs(contactus countactUs);
        public bool DeleteCountactUs(int id);
    }
}
