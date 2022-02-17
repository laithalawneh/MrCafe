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
    public class ProductOrderRepository : IProductOrderRepository
    {
        private readonly IdbContext _dbContext;

        public ProductOrderRepository(IdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<productorder> GetAllproductorder()
        {
            IEnumerable<productorder> result = _dbContext.connection.Query<productorder>("productorder_Package.GetAllproductorder", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool Createproductorder(productorder productOrder)
        {
            var p = new DynamicParameters();
            p.Add("@product_id", productOrder.productid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Order_id", productOrder.Orderid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@quantity_OF", productOrder.quantity, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = _dbContext.connection.ExecuteAsync("productorder_Package.Createproductorder", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool Updateproductorder(productorder productOrder)
        {
            var p = new DynamicParameters();
            p.Add("@PO_ID", productOrder.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@product_id", productOrder.productid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Order_id", productOrder.Orderid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@quantity_OF", productOrder.quantity, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = _dbContext.connection.ExecuteAsync("productorder_Package.Updateproductorder", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool Deleteproductorder(int id)
        {
            var p = new DynamicParameters();
            p.Add("@PO_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("productorder_Package.Deleteproductorder", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
