using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Infra.Service
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginService)
        {
            _loginRepository = loginService;
        }
        public bool CreateLogin(Login login)
        {
            return _loginRepository.insertlogin(login);
        }

        public bool DeleteLogin(int id)
        {
            return _loginRepository.deletelogin(id);
        }

        public List<Login> GetAllLogins()
        {
            return _loginRepository.getalllogin();
        }

        public List<Login> GetLoginById(Login login)
        {
            return _loginRepository.GetLoginById(login);
        }

        public List<Login> GetLoginByName(Login login)
        {
            return _loginRepository.GetLoginByName(login);
        }


        public bool UpdateLogin(Login login)
        {
            return _loginRepository.updatelogin(login);
        }
    }
}
