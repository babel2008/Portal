using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Portal.Models;

namespace Portal.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Animals.Any())
            {
                context.Animals.AddRange(
                new Animal
                {
                    Name = "Lolek",
                    Description = "Lolek to młody psiak który wraz z innym pieskiem został przerzucony w worku na posesję biednego przytuliska. ",
                    Category = "Psy",
                },
                new Animal
                {
                    Name = "Chaber",
                    Description = "Chaber to młody średniej wielkości czarny piesek",
                    Category = "Psy",
                },
                new Animal
                {
                    Name = "Kinga ",
                    Description = "Kinga to młoda sunia, która wyrosła na małego pieska. ",
                    Category = "Psy",
                },
                new Animal
                {
                    Name = "Zula ",
                    Description = "Zula vel Buba to taka psia sierotka - bo nie dość że czarna to i w średnim wieku",
                    Category = "Psy",
                },
                new Animal
                {
                    Name = "Działek ",
                    Description = "Działek trafił do schroniska 31.10.2105 roku z ul. Działkowej. ",
                    Category = "Koty",
                },
                new Animal
                {
                    Name = "Scarlett",
                    Description = "Scarlett kocha ciepłą kanapę, pełną miskę i piórko, za którym można pobiegać.",
                    Category = "Koty",
                },
                new Animal
                {
                    Name = "Budda",
                    Description = "Budda przy pierwszym kontakcie może zgrywać niedostępnego i trzeba się troszkę postarać, aby przełamać jego nieufność",
                    Category = "Koty",
                },
                new Animal
                {
                    Name = "Cody",
                    Description = "Cody długo szuka domu, być może dlatego, że jest kocim alergikiem",
                    Category = "Koty",
                },
                new Animal
                {
                    Name = "Didżej",
                    Description = "Młodziutki Didżej to wesoły i niewielki piesek",
                    Category = "Psy",
                }
                );
                                context.SaveChanges();
                            }
                        }
                    }
}