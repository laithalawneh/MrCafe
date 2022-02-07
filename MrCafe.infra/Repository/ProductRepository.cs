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
    public class ProductRepository : IProductRepository
    {
        private readonly IdbContext _dbContext;

        public ProductRepository(IdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<product> GetAllproduct()
        {
            IEnumerable<product> result = _dbContext.connection.Query<product>("product_Package.GetAllproduct", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool Createproduct(product product)
        {
            var p = new DynamicParameters();
            p.Add("Pro_name", product.productname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pro_description", product.prodescription, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Image_name", product.Imagename, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Pro_Rate", product.Rate, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Pro_price", product.price, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("Pro_Category", product.Categoryid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Pro_Cafe", product.Cafeid, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = _dbContext.connection.ExecuteAsync("product_Package.Createproduct", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool Updateproduct(product product)
        {
            var p = new DynamicParameters();
            p.Add("Pro_ID", product.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Pro_name", product.productname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pro_description", product.prodescription, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Image_name", product.Imagename, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Pro_Rate", product.Rate, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Pro_price", product.price, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("Pro_Category", product.Categoryid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Pro_Cafe", product.Cafeid, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = _dbContext.connection.ExecuteAsync("product_Package.Updateproduct", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool Deleteproduct(int id)
        {
            var p = new DynamicParameters();
            p.Add("Pro_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("product_Package.Deleteproduct", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
