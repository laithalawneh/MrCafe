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
    public class WebsiteRepository : IWebsiteRepository
    {
        private readonly IdbContext _dbContext;

        public WebsiteRepository(IdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<website> GetAllwebsite()
        {
            IEnumerable<website> result = _dbContext.connection.Query<website>("website_Package.GetAllwebsite", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool Createwebsite(website website)
        {
            var p = new DynamicParameters();
            p.Add("web_name", website.websitename, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("web_about", website.aboutus, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("web_email", website.email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("web_phone", website.phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("web_Rate", website.Rate, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("web_image1", website.image1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("web_image2", website.image2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("web_image3", website.image3, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("website_Package.Createwebsite", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool Updatewebsite(website website)
        {
            var p = new DynamicParameters();
            p.Add("web_ID", website.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("web_name", website.websitename, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("web_about", website.aboutus, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("web_email", website.email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("web_phone", website.phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("web_Rate", website.Rate, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("web_image1", website.image1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("web_image2", website.image2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("web_image3", website.image3, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("website_Package.Updatewebsite", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool Deletewebsite(int id)
        {
            var p = new DynamicParameters();
            p.Add("web_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("website_Package.Deletewebsite", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
