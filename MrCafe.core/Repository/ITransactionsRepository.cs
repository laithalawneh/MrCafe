using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Repository
{
    public interface ITransactionsRepository
    {
        public List<Transactions> GetAllTransactions();
        public bool CreateTransactions(Transactions transactions);
        public bool UpdateTransactions(Transactions transactions);
        public bool DeleteTransactions(int id);
    }
}
