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
    public class RollController : ControllerBase
    {
        private readonly IRollService _rollService;
        public RollController(IRollService rollService)
        {
            this._rollService = rollService;
        }

        //create roll
        [HttpPost("CreatRoll")]
        [ProducesResponseType(typeof(Roll), StatusCodes.Status200OK)]
        public bool CreateRoll([FromBody] Roll roll)
        {
            return _rollService.CreateRoll(roll);
        }

        //delete roll
        [HttpDelete("deleteRoll/{id}")]
        [ProducesResponseType(typeof(Roll), StatusCodes.Status200OK)]
        public bool DeleteRoll(int id)
        {
            return _rollService.DeleteRoll(id);
        }

        //getAllRolls
        [HttpGet("GetAllRolls")]
        [ProducesResponseType(typeof(List<Roll>), StatusCodes.Status200OK)]
        public List<Roll> GetAllRolls()
        {
            return _rollService.GetAllRolls();
        }

        //getRollId
        [HttpGet("GetRollId")]
        [ProducesResponseType(typeof(Roll), StatusCodes.Status200OK)]
        public List<Roll> GetRollById([FromBody] Roll roll)
        {
            return _rollService.GetRollById(roll);
        }

        //getRollName
        [HttpGet("GetRollName")]
        [ProducesResponseType(typeof(Roll), StatusCodes.Status200OK)]
        public List<Roll> GetRollByName([FromBody] Roll roll)
        {
            return _rollService.GetRollByName(roll);
        }

        //updateRoll
        [HttpPut("UpdateRoll")]
        [ProducesResponseType(typeof(Roll), StatusCodes.Status200OK)]
        public bool UpdateRoll([FromBody] Roll roll)
        {
            return _rollService.UpdateRoll(roll);
        }
    }
}
