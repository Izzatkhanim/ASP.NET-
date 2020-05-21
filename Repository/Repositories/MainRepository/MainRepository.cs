using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Repository.Data;
using Repository.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Repository.Repositories.MainRepository
{
    public interface ISliderRepository
    {
        IEnumerable<SliderItem> GetSliderItems();
    }

    public interface IAreaRepository
    {
        IEnumerable<Area> GetAreas();
    }

    public interface IBrandRepository
    {
        IEnumerable<Brand> GetBrands();
    }

    public interface ITestimonialRepository
    {
        IEnumerable<Testimonial> GetTestimonials();
    }

    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
    }

    public class SliderRepository : ISliderRepository
    {
        private readonly ThemegeniuslabDbContext _context;

        public SliderRepository(ThemegeniuslabDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SliderItem> GetSliderItems()
        {
            return _context.SliderItems.Where(s => s.Status)
                                   .OrderBy(o => o.OrderBy)
                                   .ToList();
        }
    }

    public class AreaRepository : IAreaRepository
    {
        private readonly ThemegeniuslabDbContext _context;

        public AreaRepository(ThemegeniuslabDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Area> GetAreas()
        {
            return _context.Areas.Where(l => l.Status)
                                        .ToList();
        }
    }

    public class BrandRepository : IBrandRepository
    {

        private readonly ThemegeniuslabDbContext _context;

        public BrandRepository(ThemegeniuslabDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.Where(k => k.Status)
                                                .ToList();
        }
    }

    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly ThemegeniuslabDbContext _context;

        public TestimonialRepository(ThemegeniuslabDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Testimonial> GetTestimonials()
        {
            return _context.Testimonials.Where(m => m.Status)
                                                .ToList();
        }
    }

    public class CategoryRepository : ICategoryRepository
    {
        private readonly ThemegeniuslabDbContext _context;

        public CategoryRepository(ThemegeniuslabDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.Where(p => p.Status)
                                                    .ToList();
        }
    }
}
