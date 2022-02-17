using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Service
{
    public interface ITransactionsService
    {
        public List<Transactions> GetAllTransactionss();
        public bool CreateTransactions(Transactions transactions);
        public bool UpdateTransactions(Transactions transactions);
        public bool DeleteTransactions(int id);
    }
}
