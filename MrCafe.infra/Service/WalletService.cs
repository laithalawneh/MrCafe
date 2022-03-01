using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Infra.Service
{
    public class WalletService : IWalletService
    {
        private readonly IWalletRepository _walletRepository;

        public WalletService(IWalletRepository walletService)
        {
            _walletRepository = walletService;
        }
        public bool CreateWallet(Wallet wallet)
        {
            return _walletRepository.CreateWallet(wallet);
        }

        public bool DeleteWallet(int id)
        {
            return _walletRepository.DeleteWallet(id);
        }

        public List<Wallet> GetAllWallets()
        {
            return _walletRepository.GetAllWallet();
        }

        public List<Wallet> GetWalletById(Wallet wallet)
        {
            return _walletRepository.GetWalletById(wallet);
        }

        public bool UpdateWallet(Wallet wallet)
        {
            return _walletRepository.UpdateWallet(wallet);
        }

        public bool UpdateBayWallet(Wallet wallet)
        {
            return _walletRepository.UpdateBayWallet(wallet);
        }
    }
}
