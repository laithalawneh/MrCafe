using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MrCafe.Core.Data;
using MrCafe.Core.Service;
using System.Collections.Generic;

namespace MrCafe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CafesController : ControllerBase
    {
        private readonly ICafesService _cafesService;

        public CafesController(ICafesService cafesService)
        {
            _cafesService = cafesService;
        }

        [HttpGet("GetAllCafes")]
        [ProducesResponseType(typeof(List<Cafes>), StatusCodes.Status200OK)]
        public List<Cafes> GetAllCafeses()
        {
            return _cafesService.GetAllCafes();
        }

        [HttpPost("CreateCafes")]
        [ProducesResponseType(typeof(Cafes), StatusCodes.Status200OK)]
        public bool CreateCafes([FromBody] Cafes cafes)
        {
            return _cafesService.CreateCafes(cafes);
        }


        [HttpDelete("DeleteCafes/{id}")]
        [ProducesResponseType(typeof(Cafes), StatusCodes.Status200OK)]
        public bool DeleteCafes(int id)
        {
            return _cafesService.DeleteCafes(id);
        }


        [HttpPut("UpdateCafes")]
        [ProducesResponseType(typeof(Cafes), StatusCodes.Status200OK)]
        public bool UpdateCafes([FromBody] Cafes cafes)
        {
            return _cafesService.UpdateCafes(cafes);
        }

        [HttpPost("GetCofesById")]
        [ProducesResponseType(typeof(Cafes), StatusCodes.Status200OK)]
        public List<Cafes> GetCofesById([FromBody] Cafes cafe)
        {
            return _cafesService.GetCofesById(cafe);
        }

        [HttpPost("GetCofesByName")]
        [ProducesResponseType(typeof(Cafes), StatusCodes.Status200OK)]
        public List<Cafes> GetCofesByName([FromBody] Cafes cafe)
        {
            return _cafesService.GetCofesByName(cafe.Cafesname);
        }

        [HttpPost("GetCofesByRate")]
        [ProducesResponseType(typeof(Cafes), StatusCodes.Status200OK)]
        public List<Cafes> GetCofesByRate([FromBody] Cafes cafe)
        {
            return _cafesService.GetCofesByRate(cafe);
        }

        [HttpPost("GetCofesByRateDec")]
        [ProducesResponseType(typeof(Cafes), StatusCodes.Status200OK)]
        public List<Cafes> GetCofesByRateDec()
        {
            return _cafesService.GetCofesByRateDec();
        }
    }
}
