using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ServicesRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Themegeniuslab.Models;

namespace Themegeniuslab.ViewComponents
{
    public class ServiceViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IServiceRepository _serviceRepository;

        public ServiceViewComponent(IMapper mapper, IServiceRepository serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public IViewComponentResult Invoke()
        {
            var service = _serviceRepository.GetServices();

            var model = _mapper.Map<IEnumerable<Service>, IEnumerable<ServiceViewModel>>(service);

            return View(model);
        }
    }
}
