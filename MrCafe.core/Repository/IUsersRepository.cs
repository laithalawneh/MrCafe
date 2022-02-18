using MrCafe.core.DTO;
using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Repository
{
    public interface IUsersRepository
    {
        public List<Users> getallusers();
        public bool insertusers(Users user);
        public bool updateusers(Users user);
        public bool deleteusers(int id);
        public List<Users> GetUsersById(Users user);
        public List<Users> GetUsersByName(Users user);
        public bool UserLoginDto(UserLoginDto userLoginDto);

    }
}
