using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Repository.Repositories.ServicesRepository
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly ThemegeniuslabDbContext _context;

        public ServiceRepository(ThemegeniuslabDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Service> GetServices()
        {
            return _context.Services.Where(s => s.Status)
                                   .ToList();
        }
    }
}
