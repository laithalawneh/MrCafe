using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MrCafe.Core.Data;
using MrCafe.Core.Service;
using System.Collections.Generic;

namespace MrCafe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpGet("GetAllLogins")]
        [ProducesResponseType(typeof(List<Login>), StatusCodes.Status200OK)]
        public List<Login> GetAllLogins()
        {
            return _loginService.GetAllLogins();
        }

        [HttpPost("CreateLogin")]
        [ProducesResponseType(typeof(Login), StatusCodes.Status200OK)]
        public bool CreateLogin([FromBody] Login login)
        {
            return _loginService.CreateLogin(login);
        }


        [HttpDelete("DeleteLogin/{id}")]
        [ProducesResponseType(typeof(Login), StatusCodes.Status200OK)]
        public bool DeleteLogin(int id)
        {
            return _loginService.DeleteLogin(id);
        }


        [HttpPut("UpdateLogin")]
        [ProducesResponseType(typeof(Login), StatusCodes.Status200OK)]
        public bool UpdateLogin([FromBody] Login login)
        {
            return _loginService.UpdateLogin(login);
        }

        [HttpPost("GetLoginById")]
        [ProducesResponseType(typeof(Login), StatusCodes.Status200OK)]
        public List<Login> GetCofesById([FromBody] Login login)
        {
            return _loginService.GetLoginById(login);
        }

        [HttpPost("GetLoginByName")]
        [ProducesResponseType(typeof(Login), StatusCodes.Status200OK)]
        public List<Login> GetCofesByName([FromBody] Login login)
        {
            return _loginService.GetLoginByName(login);
        }

        [HttpPost("getlogincheck")]
        [ProducesResponseType(typeof(Login), StatusCodes.Status200OK)]
        public IActionResult Getlogincheck([FromBody] Login login)
        {
            var item = _loginService.getlogincheck(login);
            if (item == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(item);
            }
        }
    }
}
