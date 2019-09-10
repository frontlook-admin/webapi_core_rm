using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using webapi_core_rm.Models;

namespace webapi_core_rm.Data
{
    public class GetMySqlData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<employmentEntities>();
                context.Database.EnsureCreated();
                //context.Database.Migrate();

                /*if (context.employee_recruit != null && context.employee_recruit.Any())
                {
                    return;
                }*/

            }
        }
    }
}
