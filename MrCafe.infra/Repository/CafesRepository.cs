using Dapper;
using MrCafe.core.common;
using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCafe.Infra.Repository
{
    public class CafesRepository : ICafesRepository
    {
        private readonly IdbContext _dbContext;

        public CafesRepository(IdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Cafes> GetAllCafes()
        {
            IEnumerable<Cafes> result = _dbContext.connection.Query<Cafes>("Cafes_Package.GetAllCafes", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool CreateCafes(Cafes cafe)
        {
            var p = new DynamicParameters();
            p.Add("Cafes_name", cafe.Cafesname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Cafes_Rate", cafe.Rate, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Cafes_latitude", cafe.latitude, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("Cafes_longitude", cafe.longitude, dbType: DbType.Double, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Cafes_package.CreateCafes", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateCafes(Cafes cafe)
        {
            var p = new DynamicParameters();
            p.Add("Cafes_id", cafe.Cafeid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Cafes_name", cafe.Cafesname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Cafes_Rate", cafe.Rate, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Cafes_latitude", cafe.latitude, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("Cafes_longitude", cafe.longitude, dbType: DbType.Double, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Cafes_package.UpdateCafes", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteCafes(int id)
        {
            var p = new DynamicParameters();
            p.Add("Cafes_id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Cafes_package.DeleteCafes", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Cafes> GetCafeById(Cafes cafe)
        {
            var p = new DynamicParameters();
            p.Add("Cafes_id", cafe.Cafeid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Cafes> result = _dbContext.connection.Query<Cafes>("Cafes_package.GetCafeById", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
        
        public List<Cafes> GetCafeByname(string name)
        {
            
            var p = new DynamicParameters();
            p.Add("Cafes_name", name, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Cafes> result = _dbContext.connection.Query<Cafes>("Cafes_package.GetCafeByname", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
        
        public List<Cafes> GetCafeByRate(Cafes cafe)
        {
            var p = new DynamicParameters();
            p.Add("Cafes_Rate", cafe.Rate, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Cafes> result = _dbContext.connection.Query<Cafes>("Cafes_package.GetCafeByRate", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<Cafes> GetCafeByDescendingRate()
        {
            IEnumerable<Cafes> result = _dbContext.connection.Query<Cafes>("Cafes_package.GetCafeByDescendingRate", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Cafes GetCafeId(Cafes cafe)
        {
            var p = new DynamicParameters();
            p.Add("Cafes_name", cafe.Cafesname, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Cafes> result = _dbContext.connection.Query<Cafes>("Cafes_package.GetCafeId", p, commandType: CommandType.StoredProcedure);

            return result.ToList().FirstOrDefault();
        }

        public async Task<Cafes> GetAllCafeProducts(int id)
        {
            var p = new DynamicParameters();
            p.Add(@"cafe_id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = await _dbContext.connection.QueryAsync<Cafes, product, Cafes>("Cafes_package.GetAllCafeProducts", (cafe, product) =>
            {
                cafe.products = cafe.products ?? new List<product>();
                cafe.products.Add(product);
                return cafe;
            },
            splitOn: "id",
            param: p,
            commandType: CommandType.StoredProcedure



            );
            var finalresult = result.AsList<Cafes>().GroupBy(p => p.Cafeid).Select(g =>
            {
                Cafes cafe = g.First();
                cafe.products = g.Where(g => g.products.Any() && g.products.Count() > 0).Select(p => p.products.Single()).GroupBy(product => product.ID).Select(p => new product
                {
                    ID = p.First().ID,
                    productname = p.First().productname,
                    price = p.First().price,
                    prodescription = p.First().prodescription,
                    Rate = p.First().Rate,
                    Imagename = p.First().Imagename,
                    Cafeid = p.First().Cafeid
                }



                ).ToList();
                return cafe;
            }).ToList();



            return finalresult.First();
        }

        public List<Cafes> GetTopCafes()
        {
            IEnumerable<Cafes> result = _dbContext.connection.Query<Cafes>("Cafes_Package.GetTopCafes", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Cafes> GetCafeByAscendingRate()
        {
            IEnumerable<Cafes> result = _dbContext.connection.Query<Cafes>("Cafes_package.GetCafeByAscendingRate", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
