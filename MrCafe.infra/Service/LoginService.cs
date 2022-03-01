using Microsoft.IdentityModel.Tokens;
using MimeKit;
using MrCafe.core.DTO;
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
                      new Claim(ClaimTypes.Role, result.Rolename),
                      new Claim(ClaimTypes.NameIdentifier,result.Userid.ToString())
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

        public List<Login> GetLoginId(Login wlogin)
        {
            return _loginRepository.GetLoginId(wlogin);
        }

        public SendEmail SentEmailUser(SendEmail UserEmail)
        {
            var result = _loginRepository.SentEmailUser(UserEmail);
            if (result != null)
            {
                MimeMessage message = new MimeMessage();
                MailboxAddress from = new MailboxAddress("MyCafe", "mycafesalsawa@gmail.com");
                message.From.Add(from);
                MailboxAddress to = new MailboxAddress("Sign-in", result.Email);
                message.To.Add(to);
                message.Subject = "Important Sign-in";
                BodyBuilder bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = string.Format("<h1>hello {0} </h1> <p>We noticed a new sign-in to your MY cafes Account on a Windows device. If this was you, you don’t need to do anything. If not, contact us so we can secure your account. <br/>mycafesalsawa@gmail.com  <p>", result.UserName);

                message.Body = bodyBuilder.ToMessageBody();
                using (var item = new MailKit.Net.Smtp.SmtpClient())
                {
                    item.Connect("smtp.gmail.com", 587, false);
                    item.Authenticate("mycafesalsawa@gmail.com", "Hh123456789");
                    item.Send(message);
                    item.Disconnect(true);

                }
            }
            return _loginRepository.SentEmailUser(UserEmail);
        }
    }
}
