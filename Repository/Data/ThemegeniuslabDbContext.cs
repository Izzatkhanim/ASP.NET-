using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository.Data
{
    public class ThemegeniuslabDbContext : DbContext
    {
        public ThemegeniuslabDbContext(DbContextOptions<ThemegeniuslabDbContext> options) : base(options) { }

        public DbSet<AboutUs> AboutUs { get; set; }

        public DbSet<AboutUsItem> AboutUsItems { get; set; }

        public DbSet<Agent> Agents { get; set; }

        public DbSet<Area> Areas { get; set; }

        public DbSet<BaseEntity> BaseEntities { get; set; }

        public DbSet<BestPlan> BestPlans { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<CaseStudy> CaseStudies { get; set; }

        public DbSet<CaseStudySpec> CaseStudySpecs { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<ContactUs> ContactUs { get; set; }

        public DbSet<Faq> Faqs { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<ServiceSpec> ServiceSpecs { get; set; }

        public DbSet<Setting> Settings { get; set; }

        public DbSet<SliderItem> SliderItems { get; set; }

        public DbSet<SocialMedia> SocialMedias { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
