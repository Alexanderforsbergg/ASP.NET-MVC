using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Webbutveckling_Backend_AlexanderForsberg.Data;
using System;
using System.Linq;

namespace Webbutveckling_Backend_AlexanderForsberg.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Webbutveckling_Backend_AlexanderForsbergContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Webbutveckling_Backend_AlexanderForsbergContext>>()))
            {
                // Look for any movies.
                if (context.City.Any())
                {
                    return;   // DB has been seeded
                }

                context.City.AddRange(
                    new City
                    {
                        CityName = "Åshammar",
                        MovedTo = DateTime.Parse("1991-12-10"),
                        MovedFrom = DateTime.Parse("2009-07-15"),
                        Country = "Sweden",

                    },
                    new City
                    {
                        CityName = "Sandviken",
                        MovedTo = DateTime.Parse("2009-07-15"),
                        MovedFrom = DateTime.Parse("2012-07-15"),
                        Country = "Sweden",

                    },

                    new City
                    {
                        CityName = "Malaga",
                        MovedTo = DateTime.Parse("2012-07-16"),
                        MovedFrom = DateTime.Parse("2013-07-16"),
                        Country = "Spain",
                    },

                    new City
                    {
                        CityName = "Malmö",
                        MovedTo = DateTime.Parse("2013-07-16"),
                        MovedFrom = DateTime.Parse("2014-07-17"),
                        Country = "Sweden",
                    },

                    new City
                    {
                        CityName = "Fuengirola",
                        MovedTo = DateTime.Parse("2014-07-18"),
                        MovedFrom = DateTime.Parse("2015-07-19"),
                        Country = "Spain",
                    },

                     new City
                     {
                        CityName = "Torre Molinos",
                        MovedTo = DateTime.Parse("2015-08-18"),
                        MovedFrom = DateTime.Parse("2016-02-19"),
                        Country = "Sweden",
                     },

                     new City
                     {
                         CityName = "Hofors",
                         MovedTo = DateTime.Parse("2016-02-18"),
                         MovedFrom = DateTime.Parse("2019-07-19"),
                         Country = "Sweden",
                     },
                     
                     new City
                     {
                        CityName = "Uppsala",
                        MovedTo = DateTime.Parse("2019-08-18"),
                        MovedFrom = DateTime.Parse("2020-07-19"),
                        Country = "Sweden",
                     },
                     
                     new City
                     {
                         CityName = "Gävle",
                         MovedTo = DateTime.Parse("2020-08-18"),
                         MovedFrom = DateTime.Parse("2022-01-03"),
                         Country = "Sweden",
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
