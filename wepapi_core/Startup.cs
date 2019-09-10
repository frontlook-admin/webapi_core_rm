using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using wepapi_core.Data;
using wepapi_core.Models;

namespace wepapi_core
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IConfiguration configuration1)
        {
            Configuration = configuration;
            //Configuration1 = configuration1;
        }

        public IConfiguration Configuration { get; }
        //public IConfiguration Configuration1 { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<employmentEntities>(
                options => options.UseMySQL(Configuration.GetConnectionString("cs")));
            //services.AddDbContext<employmentEntities>(
                //options => options.UseMySQL(Configuration1.GetConnectionString(ConfigurationManager.ConnectionStrings["cs"].ConnectionString)));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            GetMySqlData.Initialize(app);
        }
    }
}
