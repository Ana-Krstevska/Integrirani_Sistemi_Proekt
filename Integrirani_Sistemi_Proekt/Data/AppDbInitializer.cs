using Integrirani_Sistemi_Proekt.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integrirani_Sistemi_Proekt.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Shop
                if(!context.Shops.Any())
                {
                    context.Shops.AddRange(new List<Shop>()
                    {
                        new Shop()
                        {
                            Name = "Ramstore Mall",
                            Logo = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse3.mm.bing.net%2Fth%3Fid%3DOIP.FkDn1L4Rsks08ec34FazMQHaDT%26pid%3DApi&f=1",
                            Description = "Na ulica Sv. Kiril i Metodij"
                        },

                        new Shop()
                        {
                            Name = "Skopje City Mall",
                            Logo = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.JgLCXd28JJSHbvs9MU_BrgHaFj%26pid%3DApi&f=1",
                            Description = "Na bulevar Partizanski Odredi"
                        },

                        new Shop()
                        {
                            Name = "East Gate Mall",
                            Logo = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse2.mm.bing.net%2Fth%3Fid%3DOIP.H_kdWpSf4gE2MgR6Vq5DdAHaE8%26pid%3DApi&f=1",
                            Description = "Na ulica Belastisa"
                        }

                    });
                }
                //Tags
                if (!context.Tags.Any())
                {

                }
                //Brands
                if (!context.Brands.Any())
                {

                }
                //Clothings
                if (!context.Clothings.Any())
                {

                }
                //Tags & Clothings
                if (!context.Tag_Clothings.Any())
                {

                }

            }
        }
    }
}
