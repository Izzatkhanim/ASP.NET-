using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Repository.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repositories.AboutUsRepository
{
    public class AboutUsRepository : IAboutUsRepository
    {
        private readonly ThemegeniuslabDbContext _context;

        public AboutUsRepository(ThemegeniuslabDbContext context)
        {
            _context = context;
        }

        public IEnumerable<AboutUs> GetAboutUs()
        {
            return _context.AboutUs.Where(s => s.Status).ToList();
        }

        public IEnumerable<AboutUsItem> GetAboutUsItems()
        {
            return _context.AboutUsItems.Where(s => s.Status).ToList();
        }
    }
}
