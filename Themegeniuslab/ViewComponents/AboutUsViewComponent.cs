using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AboutUsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Themegeniuslab.Models;

namespace Themegeniuslab.ViewComponents
{
    public class AboutUsViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IAboutUsRepository _aboutUsRepository;

        public AboutUsViewComponent(IMapper mapper, IAboutUsRepository aboutUsRepository)
        {
            _mapper = mapper;
            _aboutUsRepository = aboutUsRepository;
        }

        public IViewComponentResult Invoke()
        {
            var aboutus = _aboutUsRepository.GetAboutUs();

            var model = _mapper.Map<IEnumerable<AboutUs>, IEnumerable<AboutUsViewModel>>(aboutus);

            return View(model);
        }
    }
}
