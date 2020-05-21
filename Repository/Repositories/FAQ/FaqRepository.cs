using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.FAQ
{
    public class FaqRepository : IFaqRepository
    {
        private readonly ThemegeniuslabDbContext _context;

        public FaqRepository(ThemegeniuslabDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Faq> GetFaqs()
        {
            return _context.Faqs.Where(s => s.Status)
                                   .OrderByDescending(a => a.CreatedAt)
                                   .ToList();
        }

    }
}
