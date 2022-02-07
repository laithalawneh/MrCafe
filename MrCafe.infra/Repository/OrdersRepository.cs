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
    public class OrdersRepository : IOrdersRepository
    {
        private readonly IdbContext _dbContext;

        public OrdersRepository(IdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Orders> GetAllOrders()
        {
            IEnumerable<Orders> result = _dbContext.connection.Query<Orders>("order_package.GetAllOrders", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool CreateOrder(Orders order)
        {
            var p = new DynamicParameters();
            p.Add("o_status", order.Status, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Date_of_Order", order.DateofOrder, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("user_i", order.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("order_package.CreateOrder", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateOrder(Orders order)
        {
            var p = new DynamicParameters();
            p.Add("o_id", order.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("o_status", order.Status, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Date_of_Order", order.DateofOrder, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("user_i", order.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("order_package.UpdateOrder", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteOrder(int id)
        {
            var p = new DynamicParameters();
            p.Add("o_id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("order_package.DeleteOrder", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
