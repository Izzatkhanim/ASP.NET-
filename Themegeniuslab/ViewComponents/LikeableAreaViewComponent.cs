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
    public class LikeableAreaViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IAreaRepository _areaRepository;

        public LikeableAreaViewComponent(IMapper mapper, IAreaRepository areaRepository)
        {
            _mapper = mapper;
            _areaRepository = areaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var area = _areaRepository.GetAreas();

            var model = _mapper.Map<IEnumerable<Area>, IEnumerable<AreaViewModel>>(area);

            return View(model);
        }
    }
}


