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
    public class AdressRepository : IAdressRepository
    {
        private readonly IdbContext _dbContext;

        public AdressRepository(IdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Adress> GetAllAdress()
        {
            IEnumerable<Adress> result = _dbContext.connection.Query<Adress>("Adress_package.GetAllAdress", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool CreateAdress(Adress adress)
        {
            var p = new DynamicParameters();
            p.Add("latin", adress.latitude, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("lang", adress.longitude, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("delivery_id", adress.deliveryid, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Adress_package.CreateAdress", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        
        public bool UpdateAdress(Adress adress)
        {
            var p = new DynamicParameters();
            p.Add("a_ID", adress.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("lat", adress.latitude, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("lang", adress.longitude, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("delivery_id", adress.deliveryid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Adress_package.UpdateAdress", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteAdress(int id)
        {
            var p = new DynamicParameters();
            p.Add("a_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Adress_package.DeleteAdress", p, commandType: CommandType.StoredProcedure);
            return true;
        }


    }
}
