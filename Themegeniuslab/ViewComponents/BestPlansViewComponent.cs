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
    public class BestPlansViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IBestPlanRepository _bestPlanRepository;

        public BestPlansViewComponent(IMapper mapper, IBestPlanRepository bestPlanRepository)
        {
            _mapper = mapper;
            _bestPlanRepository = bestPlanRepository;
        }

        public IViewComponentResult Invoke()
        {
            var bestplan = _bestPlanRepository.GetBestPlans();

            var model = _mapper.Map<IEnumerable<BestPlan>, IEnumerable<BestPlansViewModel>>(bestplan);

            return View(model);
        }
    }
}
