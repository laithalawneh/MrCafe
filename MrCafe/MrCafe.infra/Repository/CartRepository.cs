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
    public class CartRepository : ICartRepository
    {
        private readonly IdbContext _dbContext;

        public CartRepository(IdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Cart> getallCart()
        {
            IEnumerable<Cart> result = _dbContext.connection.Query<Cart>("Cart_package.getallCart", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool insertCart(Cart cart)
        {
            var p = new DynamicParameters();
            p.Add("Userid", cart.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Cart_package.insertCart", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool updateCart(Cart cart)
        {
            var p = new DynamicParameters();
            p.Add("c_ID", cart.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("User_id", cart.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Cart_package.updateCart", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool deleteCart(int id)
        {
            var p = new DynamicParameters();
            p.Add("c_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Cart_package.deleteCart", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Cart> getCartbyid(Cart cart)
        {
            var p = new DynamicParameters();
            p.Add("c_ID", cart.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Cart> result = _dbContext.connection.Query<Cart>("Cart_package.getCartbyid", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<Cart> getCartbyuserid(Cart cart)
        {
            var p = new DynamicParameters();
            p.Add("User_id", cart.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Cart> result = _dbContext.connection.Query<Cart>("Cart_package.getCartbyuserid", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
    }
}
