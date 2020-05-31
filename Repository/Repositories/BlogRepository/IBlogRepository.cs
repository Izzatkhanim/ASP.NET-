using System;
using System.Collections.Generic;
using System.Text;
using Repository.Models;

namespace Repository.Repositories.BlogRepository
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> GetBlogs();
    }
}
