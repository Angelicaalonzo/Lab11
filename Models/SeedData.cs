using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Lab11.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProfessorDbContext(serviceProvider.GetRequiredService<DbContextOptions<ProfessorDbContext>>()))
            {
                // Look for any blogs.
                if (context.Professor.Any())
                {
                    return; // DB has been seeded
                }
                
                context.Professor.AddRange(
                    new Professor
                    {
                        FirstName = "Kareem",
                        LastName  = "Dana"
                    },
                    new Professor
                    {
                        FirstName = "Nesrin",
                        LastName  = "Bakir"
                    },
                    new Professor
                    {
                        FirstName = "Sean",
                        LastName  = "Humpheries"
                    }
                );
                
                context.SaveChanges();
            }
        }

    }

}