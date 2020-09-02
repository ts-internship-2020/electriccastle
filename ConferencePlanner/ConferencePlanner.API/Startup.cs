using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConferencePlanner.Abstraction.Repository;
using ConferencePlanner.Repository.Ef.Entities;
using ConferencePlanner.Repository.Ef.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ConferencePlanner.Api.Swagger;
using Microsoft.OpenApi.Models;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Abstraction.ElectricCastleModel;

using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Repository.Ef.Repository;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Repository.Ef.Repository;
using Microsoft.Extensions.DependencyInjection;
namespace ConferencePlanner.Api
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
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<electriccastleContext > ((serviceProvider, options) =>
                {
                    var configuration = serviceProvider.GetService<IConfiguration>();
                    var connectionString = configuration.GetConnectionString("DbConnection");

                    options.UseSqlServer(connectionString, a => a.EnableRetryOnFailure())
                    .UseInternalServiceProvider(serviceProvider);


                    //int x = 0;

                });

            services.AddScoped<IGetDemoRepository, GetDemoRepository>();
            services.AddScoped<IConferenceRepository, ConferenceRepository>();
            services.AddScoped<IOrganizerConferencesRepository, OrganizerConferencesRepository>();
            services.AddScoped<ISpeakerDetailRepository, SpeakerDetailRepository>();

            services.AddScoped<IAddConferenceCountryRepository, GetCountryRepositoryEntFr>();
            services.AddScoped<IAddConferenceDistrictRepository, GetDistrictRepositoryEntFrcs>();
           
            services.AddScoped<IConferenceTypeRepository, TypeRepository>();
            services.AddScoped<IConferenceCategoryRepository, CategoryRepository>();
            services.AddScoped<IEmailParticipant, EmailRepository>();


            services.AddSwagger();
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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseSwagger(c =>
            {
                c.PreSerializeFilters.Add((swaggerDoc, httpReq) =>
                {
                    swaggerDoc.Servers = new List<OpenApiServer>
                    {
                        new OpenApiServer {Url = $"http://{httpReq.Host.Value}{httpReq.PathBase.Value}"}
                    };
                });
            });

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Conference Planner API");
            });
        }
    }
}
