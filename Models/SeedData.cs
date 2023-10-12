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
                        Size = "L to 2XL",
                        Material = "Cotton",
                        Pattern = "Cute smiling Avacados, Green",
                        Price = 6.99,
                        Rating = 5.5
                    },

                    new Socks
                    {
                        Name = "Long Coqutte Girl Aesthetic socks",
                        Size = "XS to XL",
                        Material = "Silk",
                        Pattern = "Plain and White, knee length",
                        Price = 8.99,
                        Rating = 4
                    },

                    new Socks
                    {
                        Name = "Canada, Eh? socks",
                        Size = "S to 2XL",
                        Material = "Polyester",
                        Pattern = "Red and White, Moose with Text",
                        Price = 5.99,
                        Rating = 4
                    },

                    new Socks
                    {
                        Name = "Fall themed socks",
                        Size = "S to XL",
                        Material = "Wool",
                        Pattern = "Beige leaves falling, cream and brown",
                        Price = 7.99,
                        Rating = 3
                    },

                    new Socks
                    {
                        Name = "Summer themed socks",
                        Size = "S to XL",
                        Material = "Cotton",
                        Pattern = "Smiling Sun, yellow and white, text",
                        Price = 3.99,
                        Rating = 5
                    },

                    new Socks
                    {
                        Name = "Winter themed socks",
                        Size = "S to XL",
                        Material = "Wool",
                        Pattern = "Snow falling blue and white",
                        Price = 6.99,
                        Rating = 3.7
                    },

                    new Socks
                    {
                        Name = "Good Vibes Only socks",
                        Size = "S to L",
                        Material = "Bamboo textile",
                        Pattern = "text, baby pink and baby blue",
                        Price = 2.99,
                        Rating = 3
                    },

                    new Socks
                    {
                        Name = "Gym socks",
                        Size = "S to 3XL",
                        Material = "Spandex",
                        Pattern = "Black and Plain",
                        Price = 6.99,
                        Rating = 4.6
                    },

                    new Socks
                    {
                        Name = "Barbie Socks",
                        Size = "XS to 3XL",
                        Material = "Silk",
                        Pattern = "Pretty pink, small logo in black",
                        Price = 8.99,
                        Rating = 5
                    },

                    new Socks
                    {
                        Name = "Luxury Socks",
                        Size = "S to L",
                        Material = "Cashmere",
                        Pattern = "Beige and plain",
                        Price = 9.99,
                        Rating = 3.5
                    },

                    new Socks
                    {
                        Name = "Plant themed socks",
                        Size = "S to XL",
                        Material = "Cotton",
                        Pattern = "cute plants smiling, pink background",
                        Price = 5.99,
                        Rating = 4.8
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
