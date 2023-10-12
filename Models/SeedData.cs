using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SavvySockSack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavvySockSack.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcSocksContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcSocksContext>>()))
            {
                // Look for any movies.
                if (context.Socks.Any())
                {
                    return;   // DB has been seeded
                }

                context.Socks.AddRange(
                    new Socks
                    {
                        Name = "Avacado green socks",
                        Size = "L-XL",
                        Material = "Cotton",
                        Pattern = "Cute Avacados",
                        Price = 7.99M
                    },

                    new Socks
                    {
                        Name = "Avacado green socks",
                        Size = "L-XL",
                        Material = "Cotton",
                        Pattern = "Cute Avacados",
                        Price = 7.99M
                    },

                    new Socks
                    {
                        Name = "Avacado green socks",
                        Size = "L-XL",
                        Material = "Cotton",
                        Pattern = "Cute Avacados",
                        Price = 7.99M
                    },

                    new Socks
                    {
                        Name = "Avacado green socks",
                        Size = "L-XL",
                        Material = "Cotton",
                        Pattern = "Cute Avacados",
                        Price = 7.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
