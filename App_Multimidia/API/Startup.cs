using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entites;
using Domain.Interface.repository.ministry;
using Infra.Repository.ministry;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace API
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
            // BDcontext
            services.AddDbContext<ContextEntites>(options => options.UseMySql(Configuration.GetConnectionString("myDb1")));

            // Repository
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IDay_AvailabilityRepository, Day_AvailabilityRepository>();
            services.AddScoped<IMonthly_AvailabilityRepository, Monthly_AvailabilityRepository>();
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            services.AddScoped<IPhoneRepository, PhoneRepository>();
            services.AddScoped<IScale_MemberRepository, Scale_MemberRepository>();
            services.AddScoped<IScaleRepository, ScaleRepository>();
            services.AddScoped<ISkillRepository, SkillRepository>();

            // Services

            // Outros
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
