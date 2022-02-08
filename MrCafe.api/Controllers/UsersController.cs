using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MrCafe.Core.Data;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MrCafe.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _IUsersServices;

        public UsersController(IUsersService IUsersServices)
        {
            this._IUsersServices = IUsersServices;
        }

        [HttpPost("CreatUser")]
        [ProducesResponseType(typeof(Users), StatusCodes.Status200OK)]
        public bool CreateUsers([FromBody] Users users)
        {
            return _IUsersServices.CreateUsers(users);
        }

        [HttpDelete("deleteUser/{id}")]
        [ProducesResponseType(typeof(Users), StatusCodes.Status200OK)]
        public bool DeleteUsers(int id)
        {
            return _IUsersServices.DeleteUsers(id);
        }

        [HttpGet("GetAllUsers")]
        [ProducesResponseType(typeof(List<Users>), StatusCodes.Status200OK)]
        public List<Users> GetAllUserss()
        {
            return _IUsersServices.GetAllUserss();
        }

        
        [HttpPost("GetUserId")]
        [ProducesResponseType(typeof(Users), StatusCodes.Status200OK)]
        public List<Users> GetUsersById([FromBody] Users users)
        {
            return _IUsersServices.GetUsersById(users);
        }

        //getAlltest
        [HttpPost("GetUserName")]
        [ProducesResponseType(typeof(Users), StatusCodes.Status200OK)]
        public List<Users> GetUsersByName([FromBody] Users users)
        {
            return _IUsersServices.GetUsersByName(users);
        }

        //updateTest
        [HttpPut("UpdateUser")]
        [ProducesResponseType(typeof(Users), StatusCodes.Status200OK)]
        public bool UpdateUsers([FromBody] Users users)
        {
            return _IUsersServices.UpdateUsers(users);
        }
    }
}
