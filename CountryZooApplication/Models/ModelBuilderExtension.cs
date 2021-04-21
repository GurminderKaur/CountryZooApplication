using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryZooApplication.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>().HasData(
                    new Animal
                    {
                        Id = 1,
                        Species = "Amphibian",
                        Name = "Frog",
                        Weight = 0.1
                    },
                    new Animal
                    {
                        Id = 2,
                        Species = "Mammel",
                        Name = "Rabbit",
                        Weight = 1.2
                    }
                    );
        }
    }
}
