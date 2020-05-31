using AutoMapper;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Themegeniuslab.Models;
using Themegeniuslab.ViewComponents;

namespace Themegeniuslab.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SliderItem, SliderItemViewModel>();
            CreateMap<Service, ServiceViewModel>();
            CreateMap<Testimonial, TestimonialViewModel>();
            CreateMap<AboutUsItem, AboutViewModel>();
            CreateMap<BestPlan, BestPlansViewModel>();
            CreateMap<Area, AreaViewModel>();
            CreateMap<Blog, BlogViewModel>();
            CreateMap<Faq, FaqViewModel>();
            CreateMap<AboutUs, AboutUsViewModel>();
        }
    }
}
