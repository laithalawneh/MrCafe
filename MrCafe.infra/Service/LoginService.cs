using Microsoft.IdentityModel.Tokens;
using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
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

        public string getlogincheck(Login login)
        {
            var result = _loginRepository.getlogincheck(login);

            if (result == null)
            {
                return null;
            }
            else
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.ASCII.GetBytes("[SECRET Used To Sign And Verify Jwt Token, It can be any string]");
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(
                new Claim[]
                {
                      new Claim(ClaimTypes.Name, result.UserName),
                      new Claim(ClaimTypes.Role, result.Rolename)
                }
                ),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
        }
        public bool UpdateLogin(Login login)
        {
            return _loginRepository.updatelogin(login);
        }
    }
}
