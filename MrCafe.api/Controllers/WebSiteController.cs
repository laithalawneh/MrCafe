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
    public class WebSiteController : ControllerBase
    {

        private readonly IWebsiteService _websiteService;

        public WebSiteController(IWebsiteService websiteService)
        {
            this._websiteService = websiteService;
        }

        //CreatWebSite
        [HttpPost("CreatWebSite")]
        [ProducesResponseType(typeof(website), StatusCodes.Status200OK)]
        public bool CreateWebsite([FromBody] website website)
        {
            return _websiteService.CreateWebsite(website);
        }

        //deleteWebSite
        [HttpDelete("deleteWebSite/{id}")]
        [ProducesResponseType(typeof(website), StatusCodes.Status200OK)]
        public bool DeleteWebsite(int id)
        {
            return _websiteService.DeleteWebsite(id);
        }

        //getAllWebsites
        [HttpGet("getAllWebSites")]
        [ProducesResponseType(typeof(List<website>), StatusCodes.Status200OK)]
        public List<website> GetAllWebsites()
        {
            return _websiteService.GetAllWebsites();
        }

        //UpdateWebSite
        [HttpPut("UpdateWebSite")]
        [ProducesResponseType(typeof(website), StatusCodes.Status200OK)]
        public bool UpdateWebsite([FromBody] website website)
        {
            return _websiteService.UpdateWebsite(website);
        }

        [HttpGet("websiteDetails/{id}")]
        [ProducesResponseType(typeof(List<website>), StatusCodes.Status200OK)]
        public List<website> websiteDetails(int id)
        {
            return _websiteService.websiteDetails(id);
        }
    }
}
