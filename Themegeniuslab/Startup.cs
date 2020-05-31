using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Repository.Repositories.MainRepository;
using Repository.Repositories.ServicesRepository;
using Repository.Repositories.AboutUsRepository;
using Repository.Repositories.BlogRepository;
using Repository.Repositories.FAQ;
using Repository.Repositories.AgenRepository;

namespace Themegeniuslab
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddAutoMapper(typeof(Startup));

            services.AddDbContext<ThemegeniuslabDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("Default"),
            x => x.MigrationsAssembly("Repository")));

            services.AddTransient<ITestimonialRepository, TestimonialRepository>();
            services.AddTransient<ISliderRepository, SliderRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            services.AddTransient<IAboutUsRepository, AboutUsRepository>();
            services.AddTransient<IBestPlanRepository, BestPlanRepository>();
            services.AddTransient<IAreaRepository, AreaRepository>();
            services.AddTransient<IBlogRepository, BlogRepository>();
            services.AddTransient<IFaqRepository, FaqRepository>();
            services.AddTransient<IAgentRepository, AgentRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
