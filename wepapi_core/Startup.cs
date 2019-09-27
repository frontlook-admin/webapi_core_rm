using System.Net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.EntityFrameworkCore.Infraestructure;
using webapi_core_rm.Data;
using webapi_core_rm.Interfaces;
using webapi_core_rm.Models;
using webapi_core_rm.services;

namespace webapi_core_rm
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
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
                MySQLDbContextOptionsBuilder=> MySQLDbContextOptionsBuilder.UseMySQL(Configuration.GetConnectionString("cs"))
                );
            /*services.AddDbContext<employmentEntities>(
                options => options
                .UseMySQL(Configuration.GetConnectionString("cs"))
                );*/
            //services.AddDbContext<employmentEntities>(
            //options => options.UseMySQL(Configuration1.GetConnectionString(ConfigurationManager.ConnectionStrings["cs"].ConnectionString)));
            /*services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.KnownProxies.Add(IPAddress.Parse("192.168.0.19"));
            });*/
            
            services.AddAuthentication().AddGoogle(options =>
            {
                IConfigurationSection googleAuthNSection =
                    Configuration.GetSection("Authentication:Google");

                options.ClientId = googleAuthNSection["ClientId"];
                options.ClientSecret = googleAuthNSection["ClientSecret"];
            });
            //services.AddSingleton<userinterface,userservices>();
            //services.AddMvcCore().AddAuthorization().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            GetMySqlData.Initialize(app);
        }
    }
}
