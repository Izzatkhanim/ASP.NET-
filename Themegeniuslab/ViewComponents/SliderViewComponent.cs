using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repository.Repositories.MainRepository;
using AutoMapper;
using Repository.Models;
using Themegeniuslab.Models;

namespace Themegeniuslab.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly ISliderRepository _sliderRepository;

        public SliderViewComponent(IMapper mapper, ISliderRepository sliderRepository)
        {
            _mapper = mapper;
            _sliderRepository = sliderRepository;
        }

        public IViewComponentResult Invoke()
        {
            var sliderItems = _sliderRepository.GetSliderItems();

            var model = _mapper.Map<IEnumerable<SliderItem>, IEnumerable<SliderItemViewModel>>(sliderItems);

            return View(model);
        }
    }
}
