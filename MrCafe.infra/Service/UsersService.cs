using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Infra.Service
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository IUsersRepository;

        public UsersService(IUsersRepository usersService)
        {
            IUsersRepository = usersService;
        }
        public bool CreateUsers(Users users)
        {
            return IUsersRepository.insertusers(users);
        }

        public bool DeleteUsers(int id)
        {
            return IUsersRepository.deleteusers(id);
        }

        public List<Users> GetAllUserss()
        {
            return IUsersRepository.getallusers();
        }

        public List<Users> GetUsersById(Users users)
        {
            return IUsersRepository.GetUsersById(users);
        }

        public List<Users> GetUsersByName(Users users)
        {
           return IUsersRepository.GetUsersByName(users);
        }

        public bool UpdateUsers(Users users)
        {
            return IUsersRepository.updateusers(users);
        }
    }
}
