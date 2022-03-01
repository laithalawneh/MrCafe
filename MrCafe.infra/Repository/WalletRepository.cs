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
    public class WalletRepository : IWalletRepository
    {
        private readonly IdbContext _dbContext;

        public WalletRepository(IdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Wallet> GetAllWallet()
        {
            IEnumerable<Wallet> result = _dbContext.connection.Query<Wallet>("Wallet_Package.GetAllWallet", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool CreateWallet(Wallet wallet)
        {
            var p = new DynamicParameters();
            p.Add("Wallet_Balance", wallet.Balance, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("Wallet_Cafeid", wallet.Cafeid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Wallet_Package.CreateWallet", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateWallet(Wallet wallet)
        {
            var p = new DynamicParameters();
            p.Add("Wallet_ID", wallet.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Wallet_Balance", wallet.Balance, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("Wallet_Cafeid", wallet.Cafeid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Wallet_Package.UpdateWallet", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteWallet(int id)
        {
            var p = new DynamicParameters();
            p.Add("Wallet_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Wallet_Package.DeleteWallet", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        
        public List<Wallet> GetWalletById(Wallet wallet)
        {
            var p = new DynamicParameters();
            p.Add("Wallet_ID", wallet.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Wallet> result = _dbContext.connection.Query<Wallet>("Wallet_Package.GetWalletById", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateBayWallet(Wallet wallet)
        {
            var p = new DynamicParameters();

            p.Add("Wallet_Balance", wallet.Balance, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("Wallet_Cafeid", wallet.Cafeid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.connection.ExecuteAsync("Wallet_Package.UpdateBayWallet", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
