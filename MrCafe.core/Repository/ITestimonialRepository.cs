using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Repository
{
    public interface ITestimonialRepository
    {
        public List<testimonial> GetAlltestimonial();
        public bool Createtestimonial(testimonial testimonial);
        public bool Updatetestimonial(testimonial testimonial);
        public bool Deletetestimonial(int id);
    }
}
