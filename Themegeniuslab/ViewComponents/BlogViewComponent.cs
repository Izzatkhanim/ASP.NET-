using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.BlogRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Themegeniuslab.Models;

namespace Themegeniuslab.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IBlogRepository _blogRepository;

        public BlogViewComponent(IMapper mapper, IBlogRepository blogRepository)
        {
            _mapper = mapper;
            _blogRepository = blogRepository;
        }

        public IViewComponentResult Invoke()
        {
            var blog = _blogRepository.GetBlogs();

            var model = _mapper.Map<IEnumerable<Blog>, IEnumerable<BlogViewModel>>(blog);

            return View(model);
        }
    }
}
