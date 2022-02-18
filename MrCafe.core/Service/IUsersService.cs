using MrCafe.core.DTO;
using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Service
{
    public interface IUsersService
    {
        public List<Users> GetAllUserss();
        public bool CreateUsers(Users user);
        public bool UpdateUsers(Users user);
        public bool DeleteUsers(int id);
        public List<Users> GetUsersByName(Users users);
        public List<Users> GetUsersById(Users users);
        public bool UserLoginDto(UserLoginDto userLoginDto);
    }
}
