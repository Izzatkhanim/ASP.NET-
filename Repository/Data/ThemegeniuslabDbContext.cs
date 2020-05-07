using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Repository.Data
{
    public class ThemegeniuslabDbContext : DbContext
    {
        public ThemegeniuslabDbContext(DbContextOptions<ThemegeniuslabDbContext> options) : base(options) { }
    }
}
