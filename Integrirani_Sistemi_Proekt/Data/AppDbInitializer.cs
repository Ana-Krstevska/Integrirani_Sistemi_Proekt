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
                        },

                        new Shop()
                        {
                            Name = "Capitol Mall",
                            Logo = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse3.mm.bing.net%2Fth%3Fid%3DOIP.w6A83MM2zDdlhfxXcBVEwwHaEK%26pid%3DApi&f=1",
                            Description = "Na bulevar Jane Sandanski"
                        }

                    });

                    context.SaveChanges();
                }
                //Tags
                if (!context.Tags.Any())
                {
                    context.Tags.AddRange(new List<Tag>()
                    {
                        new Tag()
                        {
                            Season = "Prolet 2022",
                            ClothingPiece = ClothingPiece.Dress,
                            Fabric = "70% viskoza, 30% poliester"
                        },

                        new Tag()
                        {
                            Season = "Prolet 2022",
                            ClothingPiece = ClothingPiece.Pants,
                            Fabric = "70% viskoza, 20% poliester, 10% elastin"
                        },

                        new Tag()
                        {
                            Season = "Leto 2022",
                            ClothingPiece = ClothingPiece.Skirt,
                            Fabric = "70% viskoza, 30% faux koza"
                        },

                        new Tag()
                        {
                            Season = "Leto 2022",
                            ClothingPiece = ClothingPiece.Top,
                            Fabric = "80% viskoza, 20% poliester"
                        },

                        new Tag()
                        {
                            Season = "Prolet 2022",
                            ClothingPiece = ClothingPiece.Accessories,
                            Fabric = "100% stainless metal"
                        },

                        new Tag()
                        {
                            Season = "Leto 2022",
                            ClothingPiece = ClothingPiece.Shoes,
                            Fabric = "100% polietan"
                        }

                    });

                    context.SaveChanges();
                }
                //Brands
                if (!context.Brands.Any())
                {
                    context.Brands.AddRange(new List<Brand>()
                    {
                        new Brand()
                        {
                            Name = "Mango",
                            ProfilePictureUrl = "https://www.underconsideration.com/brandnew/archives/mango_logo_detail.png",
                            Bio = "Prodavnica so boho-chic alista"
                        },

                        new Brand()
                        {
                            Name = "Stradivarius",
                            ProfilePictureUrl = "https://eu002.leafletcdns.com/es/data/108/logo.png",
                            Bio = "Prodavnica so moderni parcinja alista"
                        },

                        new Brand()
                        {
                            Name = "Bershka",
                            ProfilePictureUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.HvoB_Iu8qFE43O6zxtG-kAHaB5%26pid%3DApi&f=1",
                            Bio = "Prodavnica so moderni eftini parcinja alista"
                        },

                        new Brand()
                        {
                            Name = "Terranova",
                            ProfilePictureUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.9YS2cs_ZM3N2b5g_InUVDgHaHa%26pid%3DApi&f=1",
                            Bio = "Prodavnica so moderni i lesno dostapni parcinja alista"
                        },

                        new Brand()
                        {
                            Name = "New Yorker",
                            ProfilePictureUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.tlQER4xA7G9c4Icy4qew8QHaDF%26pid%3DApi&f=1",
                            Bio = "Prodavnica so moderni parcinja alista"
                        },

                        new Brand()
                        {
                            Name = "Koton",
                            ProfilePictureUrl = "https://www.avm.gen.tr/resimler/koton_5_2.jpg",
                            Bio = "Prodavnica so moderni parcinja alista"
                        }

                    });

                    context.SaveChanges();
                }
                //Clothings
                if (!context.Clothings.Any())
                {
                    context.Clothings.AddRange(new List<Clothing>()
                    {
                        new Clothing()
                        {
                            Name = "Suknja so zivotinski print",
                            Description = " Zolta suknja so zivotinski print",
                            Price = 1990,
                            ImageUrl = "https://st.mngbcn.com/rcs/pics/static/T2/fotos/S20/27092884_12_B.jpg?ts=1639586771004&imwidth=275&imdensity=2",
                            StartDate = new DateTime(2022,1,19),
                            EndDate = new DateTime (2022,3,26),
                            AmountXS = 5,
                            AmountS = 10,
                            AmountM = 15,
                            AmountL = 8,
                            AmountXL = 2,
                            BrandId = 1,
                            ShopId = 2
                        },

                        new Clothing()
                        {
                            Name = "Crn asimetricen fustan",
                            Description = "Crn asimetricen fustan",
                            Price = 3990,
                            ImageUrl = "https://st.mngbcn.com/rcs/pics/static/T2/fotos/S20/27074023_99_B.jpg?ts=1640004523981&imwidth=275&imdensity=2",
                            StartDate = new DateTime(2022,2,12),
                            EndDate = new DateTime (2022,4,26),
                            AmountXS = 2,
                            AmountS = 12,
                            AmountM = 19,
                            AmountL = 10,
                            AmountXL = 1,
                            BrandId = 1,
                            ShopId = 3
                        },

                        new Clothing()
                        {
                            Name = "Bluza so cveten motiv",
                            Description = "Bluza so dolgi rakavi, vrzuvanje na zadnata strana i so cveten motiv",
                            Price = 999,
                            ImageUrl = "https://static.bershka.net/4/photos2/2022/V/0/1/p/2413/187/615/2413187615_2_4_3.jpg?t=1644425878997",
                            StartDate = new DateTime(2022,2,14),
                            EndDate = new DateTime (2022,4,30),
                            AmountXS = 4,
                            AmountS = 19,
                            AmountM = 20,
                            AmountL = 7,
                            AmountXL = 2,
                            BrandId = 3,
                            ShopId = 1
                        },

                        new Clothing()
                        {
                            Name = "Beli cizmi",
                            Description = "Beli cizmi so patent napred",
                            Price = 2199,
                            ImageUrl = "https://nyblobstoreprod.blob.core.windows.net/product-images-public/993e7b6b6cb3bfa741a5273ae1744663.png",
                            StartDate = new DateTime(2022,1,2),
                            EndDate = new DateTime (2022,2,27),
                            AmountXS = 0,
                            AmountS = 2,
                            AmountM = 3,
                            AmountL = 1,
                            AmountXL = 0,
                            BrandId = 5,
                            ShopId = 2
                        },

                        new Clothing()
                        {
                            Name = "Portokalovi farmerki",
                            Description = "Portokalovi farmerki so visok struk i bootcut",
                            Price = 1590,
                            ImageUrl = "https://static.e-stradivarius.net/5/photos3/2022/V/0/1/p/7303/170/350/7303170350_2_1_2.jpg?t=1644843825808",
                            StartDate = new DateTime(2022,2,19),
                            EndDate = new DateTime (2022,4,27),
                            AmountXS = 2,
                            AmountS = 5,
                            AmountM = 7,
                            AmountL = 2,
                            AmountXL = 1,
                            BrandId = 2,
                            ShopId = 4
                        },

                        new Clothing()
                        {
                            Name = "Zolta tasna",
                            Description = "Zolta tasna so dolga i kratka preramka",
                            Price = 799,
                            ImageUrl = "https://static.e-stradivarius.net/5/photos3/2022/V/0/1/p/0577/201/310/0577201310_2_1_2.jpg?t=1643732311994",
                            StartDate = new DateTime(2022,2,19),
                            EndDate = new DateTime (2022,5,17),
                            AmountXS = 0,
                            AmountS = 5,
                            AmountM = 7,
                            AmountL = 4,
                            AmountXL = 0,
                            BrandId = 2,
                            ShopId = 4
                        },

                        new Clothing()
                        {
                            Name = "Suknja so cveten motiv",
                            Description = "Suknja so cventen motiv, dolzina do gluzd",
                            Price = 1990,
                            ImageUrl = "https://st.mngbcn.com/rcs/pics/static/T1/fotos/S20/17035966_99_B.jpg?ts=1630573540142&imwidth=204&imdensity=2",
                            StartDate = new DateTime(2022,2,9),
                            EndDate = new DateTime (2022,4,17),
                            AmountXS = 2,
                            AmountS = 8,
                            AmountM = 9,
                            AmountL = 2,
                            AmountXL = 0,
                            BrandId = 1,
                            ShopId = 3
                        },

                        new Clothing()
                        {
                            Name = "Crnobel fustan",
                            Description = "Fustan so crno beli rigi, dolzina nad kolena",
                            Price = 3990,
                            ImageUrl = "https://st.mngbcn.com/rcs/pics/static/T2/fotos/S20/27034039_99_B.jpg?ts=1642003563119&imwidth=275&imdensity=2",
                            StartDate = new DateTime(2022,2,27),
                            EndDate = new DateTime (2022,4,17),
                            AmountXS = 5,
                            AmountS = 10,
                            AmountM = 14,
                            AmountL = 7,
                            AmountXL = 2,
                            BrandId = 1,
                            ShopId = 3
                        }

                    }); ;

                    context.SaveChanges();
                }
                //Tags & Clothings
                if (!context.Tag_Clothings.Any())
                {
                    context.Tag_Clothings.AddRange(new List<Tag_Clothing>()
                    {
                        
                        new Tag_Clothing()
                        {
                            TagId=1,
                            ClothingId=2,
                        },
                                                
                        new Tag_Clothing()
                        {
                            TagId=2,
                            ClothingId=5,
                        },

                        new Tag_Clothing()
                        {
                            TagId=4,
                            ClothingId=3,
                        },

                        new Tag_Clothing()
                        {
                            TagId=3,
                            ClothingId=1,
                        },
                                                
                        new Tag_Clothing()
                        {
                            TagId=5,
                            ClothingId=6,
                        },

                        new Tag_Clothing()
                        {
                            TagId=6,
                            ClothingId=4,
                        },

                        new Tag_Clothing()
                        {
                            TagId=3,
                            ClothingId=7
                        },

                        new Tag_Clothing()
                        {
                            TagId=1,
                            ClothingId=8
                        }
                                               
                    }); ;

                    context.SaveChanges();
                }

            }
        }
    }
}
