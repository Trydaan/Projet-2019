using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AboMag.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AboMagContext(
                serviceProvider.GetRequiredService<DbContextOptions<AboMagContext>>()))
            {
                // Look for any movies.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }

                context.User.AddRange(
                    new User
                    {
                        Nom = "Lequeu",
                        Prenom = "Baptiste",
                        Mail = "blequeu@esimed.fr",
                        DateNaissance = DateTime.Parse("28/01/1995"),
                        LieuNaissance = "Aix-En-Provence"
                    },
                    new User
                    {
                        Nom = "Ait Yous",
                        Prenom = "Kamal",
                        Mail = "kaityous@esimed.fr",
                        DateNaissance = DateTime.Parse("28/01/1995"),
                        LieuNaissance = "Lune d'Argent"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
