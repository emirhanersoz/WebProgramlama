using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if(!context.Sinemalar.Any())
                {

                }

                if (!context.Aktörler.Any())
                {

                }

                if (!context.Yapımcılar.Any())
                {

                }

                if (!context.Filmler.Any())
                {

                }


                if (!context.Aktörler_Filmler.Any())
                {

                }


            }
        }
    }
}
