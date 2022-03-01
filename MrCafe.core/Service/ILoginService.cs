using MrCafe.core.DTO;
using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Service
{
    public interface ILoginService
    {
        public List<Login> GetAllLogins();
        public bool CreateLogin(Login wlogin);
        public bool UpdateLogin(Login wlogin);
        public bool DeleteLogin(int id);
        public List<Login> GetLoginById(Login login);
        public List<Login> GetLoginByName(Login login);
        public SendEmail SentEmailUser(SendEmail UserEmail);
        public List<Login> GetLoginId(Login wlogin);

        public string getlogincheck(Login login);
    }
}
