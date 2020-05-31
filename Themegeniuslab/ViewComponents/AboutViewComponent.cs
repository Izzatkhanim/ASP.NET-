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
    public class AboutViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IAboutUsRepository _aboutRepository;

        public AboutViewComponent(IMapper mapper, IAboutUsRepository aboutUsRepository)
        {
            _mapper = mapper;
            _aboutRepository = aboutUsRepository;
        }

        public IViewComponentResult Invoke()
        {
            var about = _aboutRepository.GetAboutUsItems();

            var model = _mapper.Map<IEnumerable<AboutUsItem>, IEnumerable<AboutViewModel>>(about);

            return View(model);
        }
    }
}
