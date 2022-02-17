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
    public class WalletController : ControllerBase
    {
        private readonly IWalletService _walletService;

        public WalletController(IWalletService walletService)
        {
            this._walletService = walletService;
        }

        //Create  wallet
        [HttpPost("CreatWallet")]
        [ProducesResponseType(typeof(Wallet), StatusCodes.Status200OK)]
        public bool CreateWallet([FromBody] Wallet wallet)
        {
            return _walletService.CreateWallet(wallet);
        }

        //delete wallet
        [HttpDelete("deleteWallet/{id}")]
        [ProducesResponseType(typeof(Wallet), StatusCodes.Status200OK)]
        public bool DeleteWallet(int id)
        {
            return _walletService.DeleteWallet(id);
        }

        //getAllWallet
        [HttpGet("getAllWallet")]
        [ProducesResponseType(typeof(List<Wallet>), StatusCodes.Status200OK)]
        public List<Wallet> GetAllWallets()
        {
            return _walletService.GetAllWallets();
        }

        //GetWalletId
        [HttpGet("GetWalletId")]
        [ProducesResponseType(typeof(Wallet), StatusCodes.Status200OK)]
        public List<Wallet> GetWalletById([FromBody] Wallet wallet)
        {
            return _walletService.GetWalletById(wallet);
        }

        //updateWallet
        [HttpPut("updateWallet")]
        [ProducesResponseType(typeof(Wallet), StatusCodes.Status200OK)]
        public bool UpdateWallet([FromBody] Wallet wallet)
        {
            return _walletService.UpdateWallet(wallet);
        }
    }
}
