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
    public class TransactionsRepository : ITransactionsRepository
    {
        private readonly IdbContext _dbContext;

        public TransactionsRepository(IdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Transactions> GetAllTransactions()
        {
            IEnumerable<Transactions> result = _dbContext.connection.Query<Transactions>("Transactions_package.GetAllTransactions", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool CreateTransactions(Transactions transactions)
        {
            var p = new DynamicParameters();
            p.Add("Trans_type", transactions.Transtype, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("amountt", transactions.amount, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("payment_id", transactions.paymentid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Wallet_id", transactions.Walletid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("transactions_package.CreateTransactions", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateTransactions(Transactions transactions)
        {
            var p = new DynamicParameters();
            p.Add("Trans_ID", transactions.TransID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Trans_type", transactions.Transtype, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("amountt", transactions.amount, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("payment_id", transactions.paymentid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Wallet_id", transactions.Walletid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("transactions_package.UpdateTransactions", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteTransactions(int id)
        {
            var p = new DynamicParameters();
            p.Add("Trans_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("transactions_package.DeleteTransactions", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
