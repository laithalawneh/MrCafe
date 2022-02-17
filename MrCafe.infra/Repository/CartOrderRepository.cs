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
    public class CartorderRepository : ICartOrderRepository
    {
        private readonly IdbContext _dbContext;

        public CartorderRepository(IdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Cartorder> getallCartorder()
        {
            IEnumerable<Cartorder> result = _dbContext.connection.Query<Cartorder>("Cartorder_package.getallCartorder", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool insertCartorder(Cartorder Cartorder)
        {
            var p = new DynamicParameters();
            p.Add("Cartid", Cartorder.Cartid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Orderid", Cartorder.Orderid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Cartorder_package.insertCartorder", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool updateCartorder(Cartorder Cartorder)
        {
            var p = new DynamicParameters();
            p.Add("c_o_ID", Cartorder.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Cart_id", Cartorder.Cartid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Order_id", Cartorder.Orderid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Cartorder_package.updateCartorder", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool deleteCartorder(int id)
        {
            var p = new DynamicParameters();
            p.Add("c_o_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Cartorder_package.deleteCartorder", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Cartorder> getCartorderbyid(Cartorder Cartorder)
        {
            var p = new DynamicParameters();
            p.Add("c_o_ID", Cartorder.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Cartorder> result = _dbContext.connection.Query<Cartorder>("Cartorder_package.getCartorderbyid", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
        
        public List<Cartorder> getCartorderbyCartid(Cartorder Cartorder)
        {
            var p = new DynamicParameters();
            p.Add("Cart_id", Cartorder.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Cartorder> result = _dbContext.connection.Query<Cartorder>("Cartorder_package.getCartorderbyCartid", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
    }
}
