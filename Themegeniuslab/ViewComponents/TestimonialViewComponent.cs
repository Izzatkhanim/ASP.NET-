using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.MainRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Themegeniuslab.Models;

namespace Themegeniuslab.ViewComponents
{
    public class TestimonialViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly ITestimonialRepository _testimonialRepository;

        public TestimonialViewComponent(IMapper mapper, ITestimonialRepository testimonialRepository)
        {
            _mapper = mapper;
            _testimonialRepository = testimonialRepository;
        }

        public IViewComponentResult Invoke()
        {
            var testimonial = _testimonialRepository.GetTestimonials();

            var model = _mapper.Map<IEnumerable<Testimonial>, IEnumerable<TestimonialViewModel>>(testimonial);

            return View(model);
        }
    }
}
