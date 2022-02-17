using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Infra.Service
{
    public class TransactionsService : ITransactionsService
    {
        private readonly ITransactionsRepository _transactionsRepository;

        public TransactionsService(ITransactionsRepository transactionsService)
        {
            _transactionsRepository = transactionsService;
        }
        public bool CreateTransactions(Transactions transactions)
        {
            return _transactionsRepository.CreateTransactions(transactions);
        }

        public bool DeleteTransactions(int id)
        {
            return _transactionsRepository.DeleteTransactions(id);
        }

        public List<Transactions> GetAllTransactionss()
        {
            return _transactionsRepository.GetAllTransactions();
        }

        public bool UpdateTransactions(Transactions transactions)
        {
            return _transactionsRepository.UpdateTransactions(transactions);
        }
    }
}
