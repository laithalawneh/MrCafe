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
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            this._testimonialService = testimonialService;
        }

        //create test
        [HttpPost("CreatTestimonial")]
        [ProducesResponseType(typeof(testimonial), StatusCodes.Status200OK)]
        public bool CreateTestimonial([FromBody] testimonial testimonial)
        {
            return _testimonialService.CreateTestimonial(testimonial);
        }

        //delete test
        [HttpDelete("deleteTestimonial/{id}")]
        [ProducesResponseType(typeof(testimonial), StatusCodes.Status200OK)]
        public bool DeleteTestimonial(int id)
        {
            return _testimonialService.DeleteTestimonial(id);
        }

        //getAlltest
        [HttpGet("GetAllTestimonial")]
        [ProducesResponseType(typeof(List<testimonial>), StatusCodes.Status200OK)]
        public List<testimonial> GetAllTestimonials()
        {
            return _testimonialService.GetAllTestimonials();
        }

        //updateTest
        [HttpPut("UpdateTestimonial")]
        [ProducesResponseType(typeof(List<testimonial>), StatusCodes.Status200OK)]
        public bool UpdateTestimonial([FromBody] testimonial testimonial)
        {
            return _testimonialService.UpdateTestimonial(testimonial);
        }
    }
}
