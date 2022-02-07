using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MrCafe.Core.Data;
using MrCafe.Core.Service;
using System.Collections.Generic;

namespace MrCafe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdressController : Controller
    {

        private readonly IAdressService _adressService;

        public AdressController(IAdressService adressService)
        {
            _adressService =  adressService;
        }

        [HttpGet("GetAllAdresses")]
        [ProducesResponseType(typeof(List<Adress>), StatusCodes.Status200OK)]
        public List<Adress> GetAllAdresses()
        {
            return _adressService.GetAllAdresses();
        }

        [HttpPost("CreateAdress")]
        [ProducesResponseType(typeof(Adress), StatusCodes.Status200OK)]
        public bool CreateAdress([FromBody] Adress adress)
        {
            return _adressService.CreateAdress(adress);
        }


        [HttpDelete("DeleteAdress/{id}")]
        [ProducesResponseType(typeof(Adress), StatusCodes.Status200OK)]
        public bool DeleteAdress(int id)
        {
            return _adressService.DeleteAdress(id);
        }


        [HttpPut("UpdateAdress")]
        [ProducesResponseType(typeof(Adress), StatusCodes.Status200OK)]
        public bool UpdateAdress([FromBody] Adress adress)
        {
            return _adressService.UpdateAdress(adress);
        }

    }
}
