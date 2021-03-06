using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intelltech.Data;
using Intelltech.Interfaces;
using Intelltech.Models;
using Intelltech.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Intelltech
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
            string connection = "Server=localhost;DataBase=ProjetoTeste;Uid=root;Pwd=";
            services.AddDbContext<DataContext>(options => options.UseMySQL(connection));
            services.AddScoped<DataContext, DataContext>();
            services.AddScoped<ErrorDetails, ErrorDetails>();
            services.AddTransient<IDirectoriesRepository, DirectoriesRepository>();
            services.AddTransient<IGeometricShapesRepository, GeometricShapesRepository>();
            services.AddControllers().AddNewtonsoftJson();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
