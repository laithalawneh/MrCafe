using Dapper;
using MrCafe.core.common;
using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MrCafe.Infra.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly IdbContext _dbContext;

        public LoginRepository(IdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Login> getalllogin()
        {
            IEnumerable<Login> result = _dbContext.connection.Query<Login>("Login_package.getalllogin", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool insertlogin(Login login)
        {
            var p = new DynamicParameters();
            p.Add("UserName", login.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Password", login.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Roll", login.Roll, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Userid", login.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Cafeid", login.Cafeid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Login_package.insertlogin", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool updatelogin(Login login)
        {
            var p = new DynamicParameters();
            p.Add("l_ID", login.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("User_Name", login.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Password1", login.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Roll1", login.Roll, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Userid1", login.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Cafeid1", login.Cafeid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Login_package.updatelogin", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool deletelogin(int id)
        {
            var p = new DynamicParameters();
            p.Add("l_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Login_package.deletelogin", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Login> GetLoginById(Login login)
        {
            var p = new DynamicParameters();
            p.Add("l_ID", login.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Login> result = _dbContext.connection.Query<Login>("Login_package.getloginbyid", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
        
        public List<Login> GetLoginByName(Login login)
        {
            var p = new DynamicParameters();
            p.Add("User_Name", login.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Login> result = _dbContext.connection.Query<Login>("Login_package.getloginbyid", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
    }
}
