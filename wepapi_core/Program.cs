using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace webapi_core_rm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();*/
            CreateWebHostBuilder(args).Build().Run();
            /*var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseUrls("http://localhost:5000", "http://odin:5000", "http://192.168.1.2:5000")
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();*/
            /*var configuration = new ConfigurationBuilder()
                .AddCommandLine(args)
                .Build();


            var hostUrl = configuration["hosturl"];
            if (string.IsNullOrEmpty(hostUrl))
                hostUrl = "http://0.0.0.0:6000";


            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls(hostUrl)   // <!-- this 
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseConfiguration(configuration)
                .Build();

            host.Run();*/
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://localhost:5000", "http://103.127.157.109:5000", "https://103.127.157.109:5001" )
                .UseStartup<Startup>();

        /*var host = new WebHostBuilder()
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseIISIntegration()
            .UseStartup()
            .Build();

        host.Run();*/

        
    }
}
