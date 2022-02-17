using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MrCafe.Core.Data;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MrCafe.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionsService _transactionsService;

        public TransactionsController(ITransactionsService transactionsService)
        {
            this._transactionsService = transactionsService;
        }

        //creat Trans
        [HttpPost("CreatTrans")]
        [ProducesResponseType(typeof(Transactions), StatusCodes.Status200OK)]
        public bool CreateTransactions([FromBody] Transactions transactions)
        {
            return _transactionsService.CreateTransactions(transactions);
        }

        //delete trans
        [HttpDelete("deleteTrans/{id}")]
        [ProducesResponseType(typeof(Transactions), StatusCodes.Status200OK)]
        public bool DeleteTransactions(int id)
        {
            return _transactionsService.DeleteTransactions(id);
        }

        //get All Trans
        [HttpGet("GetAllTransactions")]
        [ProducesResponseType(typeof(List<Transactions>), StatusCodes.Status200OK)]
        public List<Transactions> GetAllTransactionss()
        {
            return _transactionsService.GetAllTransactionss();
        }

        //updateTest
        [HttpPut("UpdateTrans")]
        [ProducesResponseType(typeof(Transactions), StatusCodes.Status200OK)]
        public bool UpdateTransactions([FromBody] Transactions transactions)
        {
            return _transactionsService.UpdateTransactions(transactions);
        }
    }
}
