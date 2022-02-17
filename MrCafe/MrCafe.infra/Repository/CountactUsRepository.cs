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
    public class CountactUsRepository : ICountactUsRepository
    {
        private readonly IdbContext _dbContext;

        public CountactUsRepository(IdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<contactus> GetAllcontactus()
        {
            IEnumerable<contactus> result = _dbContext.connection.Query<contactus>("contactus_Package.GetAllcontactus", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool Createcontactus(contactus countactUs)
        {
            var p = new DynamicParameters();
            p.Add("C_Name", countactUs.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("C_subject", countactUs.SUBJECT, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("C_message", countactUs.message, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("C_senderemail", countactUs.senderemail, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("C_receiveremail", countactUs.receiveremail, dbType: DbType.String, direction: ParameterDirection.Input);
           
            var result = _dbContext.connection.ExecuteAsync("contactus_Package.Createcontactus", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool Updatecontactus(contactus countactUs)
        {
            var p = new DynamicParameters();
            p.Add("C_ID", countactUs.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("C_Name", countactUs.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("C_subject", countactUs.SUBJECT, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("C_message", countactUs.message, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("C_senderemail", countactUs.senderemail, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("C_receiveremail", countactUs.receiveremail, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = _dbContext.connection.ExecuteAsync("contactus_Package.Updatecontactus", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        //kkklpokmlk
        public bool Deletecontactus(int id)
        {
            var p = new DynamicParameters();
            p.Add("C_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("contactus_Package.Deletecontactus", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
