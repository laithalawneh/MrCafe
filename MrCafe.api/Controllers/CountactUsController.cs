using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MrCafe.Core.Data;
using MrCafe.Core.Service;
using System.Collections.Generic;

namespace MrCafe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountactUsController : ControllerBase
    {
        private readonly ICountactUsService _countactUsService;

        public CountactUsController(ICountactUsService countactUsService)
        {
            _countactUsService = countactUsService;
        }

        [HttpGet("GetAllCountactUss")]
        [ProducesResponseType(typeof(List<contactus>), StatusCodes.Status200OK)]
        public List<contactus> GetAllCountactUss()
        {
            return _countactUsService.GetAllCountactUss();
        }

        [HttpPost("CreateCountactUs")]
        [ProducesResponseType(typeof(contactus), StatusCodes.Status200OK)]
        public bool CreateCountactUs([FromBody] contactus countactUs)
        {
            return _countactUsService.CreateCountactUs(countactUs);
        }


        [HttpDelete("DeleteCountactUs/{id}")]
        [ProducesResponseType(typeof(contactus), StatusCodes.Status200OK)]
        public bool DeleteCountactUs(int id)
        {
            return _countactUsService.DeleteCountactUs(id);
        }


        [HttpPut("UpdateCountactUs")]
        [ProducesResponseType(typeof(contactus), StatusCodes.Status200OK)]
        public bool UpdateCountactUs([FromBody] contactus countactUs)
        {
            return _countactUsService.UpdateCountactUs(countactUs);
        }

        
    }
}
