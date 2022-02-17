using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Service
{
    public interface ITestimonialService
    {
        public List<testimonial> GetAllTestimonials();
        public bool CreateTestimonial(testimonial testimonial);
        public bool UpdateTestimonial(testimonial testimonial);
        public bool DeleteTestimonial(int id);
    }
}
