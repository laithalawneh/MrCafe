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
    public class DeliveryRepository : IDeliveryRepository
    {
        private readonly IdbContext _dbContext;

        public DeliveryRepository(IdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<delivery> GetAllDelivery()
        {
            IEnumerable<delivery> result = _dbContext.connection.Query<delivery>("delivery_package.GetAllDelivery", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool CreateDelivery(delivery delivery)
        {
            var p = new DynamicParameters();
            p.Add("n", delivery.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("p", delivery.phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("user_n", delivery.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pass", delivery.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("s", delivery.Status, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("sal", delivery.Salary, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("delivery_package.CreateDelivery", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateDelivery(delivery delivery)
        {
            var p = new DynamicParameters();
            p.Add("d_id", delivery.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("n", delivery.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("p", delivery.phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("user_n", delivery.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pass", delivery.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("s", delivery.Status, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("sal", delivery.Salary, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("delivery_package.UpdateDelivery", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteDelivery(int id)
        {
            var p = new DynamicParameters();
            p.Add("d_id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("delivery_package.DeleteDelivery", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
