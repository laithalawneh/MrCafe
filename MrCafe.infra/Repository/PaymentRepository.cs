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
    public class PaymentRepository : IPaymentRepository
    {
        private readonly IdbContext _dbContext;

        public PaymentRepository(IdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<payment> GetAllPayments()
        {
            IEnumerable<payment> result = _dbContext.connection.Query<payment>("payment_package.GetAllPayments", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool CreatePayment(payment payment)
        {
            var p = new DynamicParameters();
            p.Add("serial_num", payment.serialnumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pass", payment.password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("bala_nce", payment.Balance, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("user_i", payment.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("payment_package.CreatePayment", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdatePayment(payment payment)
        {
            var p = new DynamicParameters();
            p.Add("p_id", payment.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("serial_num", payment.serialnumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pass", payment.password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("bala_nce", payment.Balance, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("user_i", payment.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("payment_package.UpdatePayment", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeletePayment(int id)
        {
            var p = new DynamicParameters();
            p.Add("p_id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("payment_package.DeletePayment", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
