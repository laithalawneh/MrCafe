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
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly IdbContext _dbContext;

        public TestimonialRepository(IdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<testimonial> GetAlltestimonial()
        {
            IEnumerable<testimonial> result = _dbContext.connection.Query<testimonial>("testimonial_Package.GetAlltestimonial", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool Createtestimonial(testimonial testimonial)
        {
            var p = new DynamicParameters();
            p.Add("test_Name", testimonial.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("test_content", testimonial.testcontent, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("test_Status", testimonial.Status, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("test_userid", testimonial.userid, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = _dbContext.connection.ExecuteAsync("testimonial_Package.Createtestimonial", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool Updatetestimonial(testimonial testimonial)
        {
            var p = new DynamicParameters();
            p.Add("test_ID", testimonial.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("test_Name", testimonial.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("test_content", testimonial.testcontent, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("test_Status", testimonial.Status, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("test_userid", testimonial.userid, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = _dbContext.connection.ExecuteAsync("testimonial_Package.Updatetestimonial", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool Deletetestimonial(int id)
        {
            var p = new DynamicParameters();
            p.Add("test_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("testimonial_Package.Deletetestimonial", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
