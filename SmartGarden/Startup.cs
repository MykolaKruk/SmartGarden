using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SmartGarden.Core.Data;
using SmartGarden.Core.Entities;
using SmartGarden.Core.Services;
using SmartGarden.Data;
using SmartGarden.Services;
using Swashbuckle.AspNetCore.Swagger;

namespace SmartGarden
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
            services.AddScoped<IFlowerService, FlowerService>();
            services.AddScoped<IFlowerTypeService, FlowerTypeService>();
            services.AddScoped<IMeasureUnitService, MeasureUnitService>();
            services.AddScoped<IWateringSettingsService, WateringSettingsService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new Info { Title = "SmartGarden" });
            });

            // configure database context
            services.AddDbContext<FlowerpotContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // set up IdentityRole 
            services.AddIdentity<AppUser, IdentityRole>(opts => {
                    opts.Password.RequiredLength = 6;
                    opts.Password.RequireNonAlphanumeric = false;
                    opts.Password.RequireLowercase = false;
                    opts.Password.RequireUppercase = false;
                    opts.Password.RequireDigit = false;
                    opts.User.RequireUniqueEmail = true;
                }).AddEntityFrameworkStores<FlowerpotContext>()
                .AddDefaultTokenProviders();

            services.AddAutoMapper(a => a.AddProfile(new SmartGarden.Core.MappingProfile()));

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                try
                {
                    var context = serviceProvider.GetRequiredService<FlowerpotContext>();
                    FlowerpotInitializer.Initialize(context, app.ApplicationServices, Configuration).Wait();
                }
                catch (Exception ex)
                {
                    var logger = serviceProvider.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                    throw;
                }
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "SmartGarden");
            });

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();
        }
    }
}
