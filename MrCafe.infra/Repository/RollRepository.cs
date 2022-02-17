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
    public class RollRepository : IRollRepository
    {
        private readonly IdbContext _dbContext;

        public RollRepository(IdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Roll> getallRoll()
        {
            IEnumerable<Roll> result = _dbContext.connection.Query<Roll>("Roll_package.getallRoll", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool insertRoll(Roll roll)
        {
            var p = new DynamicParameters();
            p.Add("Rollname", roll.Rollname, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Roll_package.insertRoll", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool updateRoll(Roll roll)
        {
            var p = new DynamicParameters();
            p.Add("R_ID", roll.ID, dbType: DbType.Int32, direction: ParameterDirection.Input); 
            p.Add("Roll_name", roll.Rollname, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Roll_package.updateRoll", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool deleteRoll(int id)
        {
            var p = new DynamicParameters();
            p.Add("R_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Roll_package.deleteRoll", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Roll> GetRollById(Roll roll)
        {
            var p = new DynamicParameters();
            p.Add("R_ID", roll.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Roll> result = _dbContext.connection.Query<Roll>("Roll_package.getRollbyid", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<Roll> GetRollByName(Roll roll)
        {
            var p = new DynamicParameters();
            p.Add("Roll_name", roll.Rollname, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Roll> result = _dbContext.connection.Query<Roll>("Roll_package.getRollbyrollname", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
    }
}
