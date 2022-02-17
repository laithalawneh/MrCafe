using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Infra.Service
{
    public class TestimonialService : ITestimonialService
    {
        private readonly ITestimonialRepository _testimonialRepository;

        public TestimonialService(ITestimonialRepository testimonialService)
        {
            _testimonialRepository = testimonialService;
        }
        public bool CreateTestimonial(testimonial testimonial)
        {
            return _testimonialRepository.Createtestimonial(testimonial);
        }

        public bool DeleteTestimonial(int id)
        {
            return _testimonialRepository.Deletetestimonial(id);
        }

        public List<testimonial> GetAllTestimonials()
        {
            return _testimonialRepository.GetAlltestimonial();
        }

        public bool UpdateTestimonial(testimonial testimonial)
        {
            return _testimonialRepository.Updatetestimonial(testimonial);
        }
    }
}
