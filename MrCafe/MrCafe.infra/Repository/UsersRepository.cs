using Dapper;
using MrCafe.core.common;
using MrCafe.core.DTO;
using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MrCafe.Infra.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly IdbContext _dbContext;

        public UsersRepository(IdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Users> getallusers()
        {
            IEnumerable<Users> result = _dbContext.connection.Query<Users>("Users_package.getallusers", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool insertusers(Users users)
        {
            var p = new DynamicParameters();
            p.Add("Fname", users.Fname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Lname", users.Lname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("email", users.email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("phone", users.phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("latitude", users.latitude, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("longitude", users.longitude, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("Salary", users.Salary, dbType: DbType.Double, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Users_package.insertusers", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool updateusers(Users users)
        {
            var p = new DynamicParameters();
            p.Add("User_id", users.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("F_name", users.Fname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("L_name", users.Lname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("email1", users.email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("phone1", users.phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("lat_itude", users.latitude, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("long_itude", users.longitude, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("Salary1", users.Salary, dbType: DbType.Double, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Users_package.updateusers", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool deleteusers(int id)
        {
            var p = new DynamicParameters();
            p.Add("User_id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Users_package.deleteusers", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Users> GetUsersById(Users users)
        {
            var p = new DynamicParameters();
            p.Add("User_id", users.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Users> result = _dbContext.connection.Query<Users>("Users_package.getuserbyid", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
        
        public List<Users> GetUsersByName(Users users)
        {
            var p = new DynamicParameters();
            p.Add("F_name", users.Fname, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Users> result = _dbContext.connection.Query<Users>("Users_package.getuserbyname", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<Users> getUserId(Users users) {
            var p = new DynamicParameters();
            p.Add("F_name", users.Fname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("L_name", users.Lname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("phoneNum", users.phone, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Users> result = _dbContext.connection.Query<Users>("Users_package.getUserId", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public bool UserLoginDto(UserLoginDto userLoginDto)
        {
            var p = new DynamicParameters();
            p.Add("Fname", userLoginDto.Fname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Lname", userLoginDto.Lname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("email", userLoginDto.email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("phone", userLoginDto.phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("latitude", userLoginDto.latitude, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("longitude", userLoginDto.longitude, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("Salary", userLoginDto.salary, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("UserName", userLoginDto.userName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Password", userLoginDto.password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Roll", userLoginDto.Roll, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Userid", userLoginDto.userId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Cafeid", userLoginDto.CafeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Users_package.UserLoginDto", p, commandType: CommandType.StoredProcedure);
            return true;
        }

    }
}
