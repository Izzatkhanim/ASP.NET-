using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repository.Data;
using Repository.Models;

namespace Repository.Repositories.BlogRepository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly ThemegeniuslabDbContext _context;

        public BlogRepository(ThemegeniuslabDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Blog> GetBlogs()
        {
            return _context.Blogs.ToList();
        }
    }
}
