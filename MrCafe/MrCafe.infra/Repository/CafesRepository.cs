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
    public class CafesRepository : ICafesRepository
    {
        private readonly IdbContext _dbContext;

        public CafesRepository(IdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Cafes> GetAllCafes()
        {
            IEnumerable<Cafes> result = _dbContext.connection.Query<Cafes>("Cafes_Package.GetAllCafes", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool CreateCafes(Cafes cafe)
        {
            var p = new DynamicParameters();
            p.Add("Cafes_name", cafe.Cafesname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Cafes_Rate", cafe.Rate, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Cafes_latitude", cafe.latitude, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("Cafes_longitude", cafe.longitude, dbType: DbType.Double, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Cafes_package.CreateCafes", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateCafes(Cafes cafe)
        {
            var p = new DynamicParameters();
            p.Add("Cafes_id", cafe.Cafeid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Cafes_name", cafe.Cafesname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Cafes_Rate", cafe.Rate, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Cafes_latitude", cafe.latitude, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("Cafes_longitude", cafe.longitude, dbType: DbType.Double, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Cafes_package.UpdateCafes", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteCafes(int id)
        {
            var p = new DynamicParameters();
            p.Add("Cafes_id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Cafes_package.DeleteCafes", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Cafes> GetCafeById(Cafes cafe)
        {
            var p = new DynamicParameters();
            p.Add("Cafes_id", cafe.Cafeid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Cafes> result = _dbContext.connection.Query<Cafes>("Cafes_package.GetCafeById", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
        
        public List<Cafes> GetCafeByname(string name)
        {
            
            var p = new DynamicParameters();
            p.Add("Cafes_name", name, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Cafes> result = _dbContext.connection.Query<Cafes>("Cafes_package.GetCafeByname", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
        
        public List<Cafes> GetCafeByRate(Cafes cafe)
        {
            var p = new DynamicParameters();
            p.Add("Cafes_Rate", cafe.Rate, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Cafes> result = _dbContext.connection.Query<Cafes>("Cafes_package.GetCafeByRate", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<Cafes> GetCafeByDescendingRate()
        {
            IEnumerable<Cafes> result = _dbContext.connection.Query<Cafes>("Cafes_package.GetCafeByDescendingRate", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }



    }
}
