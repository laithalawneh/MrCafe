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
            p.Add("productid", Cartorder.Productid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("user_id", Cartorder.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("quantity", Cartorder.Quantity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Cartorder_package.insertCartorder", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool updateCartorder(Cartorder Cartorder)
        {
            var p = new DynamicParameters();
            p.Add("c_o_ID", Cartorder.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("user_id", Cartorder.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("product_id", Cartorder.Productid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("c_quantity", Cartorder.Quantity, dbType: DbType.Int32, direction: ParameterDirection.Input);
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

        public List<CartDTO> getCartorderbyUserid(Cartorder Cartorder)
        {
            var p = new DynamicParameters();
            p.Add("user_id", Cartorder.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<CartDTO> result = _dbContext.connection.Query<CartDTO>("Cartorder_package.getCartorderbyUserid", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
    }
}