using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMusic.Models;
using System;
using System.Linq;

namespace RazorPagesMusic.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMusicContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMusicContext>>()))
            {
                // Look for any movies.
                if (context.Music.Any())
                {
                    return;   // DB has been seeded
                }

                context.Music.AddRange(
                    new Music
                    {
                        Album = "Lover",
                        ReleaseDate = DateTime.Parse("2019-8-23"),
                        Genre = "Pop",
                        Artist = "Taylor Swift"
                    },

                    new Music
                    {
                        Album = "Rare ",
                        ReleaseDate = DateTime.Parse("2020-1-10"),
                        Genre = "Pop",
                        Artist = "Selena Gomez"
                    },

                    new Music
                    {
                        Album = "After Hours",
                        ReleaseDate = DateTime.Parse("2020-4-20"),
                        Genre = "R&B/Soul",
                        Artist = "The Weeknd"
                    },

                    new Music
                    {
                        Album = "=",
                        ReleaseDate = DateTime.Parse("2021-10-29"),
                        Genre = "Pop",
                        Artist = "Ed Sheeran"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}