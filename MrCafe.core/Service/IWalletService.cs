using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Service
{
    public interface IWalletService
    {
        public List<Wallet> GetAllWallets();
        public bool CreateWallet(Wallet wallet);
        public bool UpdateWallet(Wallet wallet);
        public bool DeleteWallet(int id);
        public List<Wallet> GetWalletById(Wallet wallet);
    }
}
