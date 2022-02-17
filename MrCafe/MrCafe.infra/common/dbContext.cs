using Microsoft.Extensions.Configuration;
using MrCafe.core.common;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace MrCafe.infra.common
{

    public class dbContext : IdbContext
    {
        private DbConnection _connection;
        private readonly IConfiguration configuration; 
        public dbContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public DbConnection connection
        {
            get
            {

                //case 1 
                if (_connection == null)
                {

                    _connection = new OracleConnection(configuration[("ConnectionStrings:DBConnectionString")]);
                    _connection.Open();
                }
                //case 2 
                else if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
                return _connection;
            }
        }
    }
}
