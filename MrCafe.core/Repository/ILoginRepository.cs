using MrCafe.core.DTO;
using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Repository
{
    public interface ILoginRepository
    {
        public List<Login> getalllogin();
        public bool insertlogin(Login wlogin);
        public bool updatelogin(Login wlogin);
        public bool deletelogin(int id);
        public List<Login> GetLoginById(Login wlogin);
        public List<Login> GetLoginByName(Login wlogin);
        public List<Login> GetLoginId(Login wlogin);
        public SendEmail SentEmailUser(SendEmail UserEmail);

        public Login getlogincheck(Login wlogin);


    }
}
