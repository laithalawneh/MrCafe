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
    public class DeliveryOrderRepository : IDeliveryOrderRepository
    {
        private readonly IdbContext _dbContext;

        public DeliveryOrderRepository(IdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<deliveryorder> GetAlldeliveryorder()
        {
            IEnumerable<deliveryorder> result = _dbContext.connection.Query<deliveryorder>("deliveryorder_Package.GetAlldeliveryorder", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool Createdeliveryorder(deliveryorder deliveryOrder)
        {
            var p = new DynamicParameters();
            p.Add("delivery_id", deliveryOrder.deliveryid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Order_id", deliveryOrder.Orderid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("deliveryorder_Package.Createdeliveryorder", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool Updatedeliveryorder(deliveryorder deliveryOrder)
        {
            var p = new DynamicParameters();
            p.Add("DO_ID", deliveryOrder.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("delivery_id", deliveryOrder.deliveryid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Order_id", deliveryOrder.Orderid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("deliveryorder_Package.Updatedeliveryorder", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool Deletedeliveryorder(int id)
        {
            var p = new DynamicParameters();
            p.Add("DO_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("deliveryorder_Package.Deletedeliveryorder", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
