using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMonster4.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMonster4.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMonster4Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMonster4Context>>()))
            {
                // Look for any monsters.
                if (context.Monster.Any())
                {
                    return;   // DB has been seeded
                }

                context.Monster.AddRange(
                    new Monster
                    {
                        MonsterName = "Ted",
                        ReleaseDate = DateTime.Parse("1996-8-20"),
                        Genre = "Rock Stars",
                        Price = 4500M,
                        Rating = "A"
                    },

                    new Monster
                    {
                        MonsterName = "Bruno",
                        ReleaseDate = DateTime.Parse("1987-7-14"),
                        Genre = "Rock Stars",
                        Price = 2300M,
                        Rating = "A"
                    },

                    new Monster
                    {
                        MonsterName = "Bake Sale",
                        ReleaseDate = DateTime.Parse("1948-6-10"),
                        Genre = "Animated Food",
                        Price = 1000M,
                        Rating = "A"
                    },

                    new Monster
                    {
                        MonsterName = "Cap'n Crunch",
                        ReleaseDate = DateTime.Parse("1964-2-28"),
                        Genre = "Animated Food",
                        Price = 7350M,
                        Rating = "A"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
