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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IdbContext _dbContext;

        public CategoryRepository(IdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Category> GetAllCategory()
        {
            IEnumerable<Category> result = _dbContext.connection.Query<Category>("Category_Package.GetAllCategory", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool CreateCategory(Category category)
        {
            var p = new DynamicParameters();
            p.Add("Cat_name", category.Categoryname, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Category_Package.CreateCategory", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateCategory(Category category)
        {
            var p = new DynamicParameters();
            p.Add("Cat_ID", category.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Cat_name", category.Categoryname, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Category_Package.UpdateCategory", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteCategory(int id)
        {
            var p = new DynamicParameters();
            p.Add("Cat_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Category_Package.DeleteCategory", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Category> GetCategoryById(Category category)
        {
            var p = new DynamicParameters();
            p.Add("Cat_ID", category.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Category> result = _dbContext.connection.Query<Category>("Category_Package.GetCategoryById", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

       
    }
}
