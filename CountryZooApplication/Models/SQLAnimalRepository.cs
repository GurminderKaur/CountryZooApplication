using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryZooApplication.Models
{
    public class SQLAnimalRepository : IAnimalRepository
    {
        private readonly AppDbContext context;

        public SQLAnimalRepository( AppDbContext context)
        {
            this.context = context;
        }
        public Animal Add(Animal animal)
        {
            context.Animals.Add(animal);
            context.SaveChanges();
            return animal;
        }

        public Animal Delete(int Id)
        {

            Animal animal = context.Animals.Find(Id);
            if (animal != null) {
                context.Animals.Remove(animal);
                context.SaveChanges();
            }
            return animal;
        }

        public IEnumerable<Animal> GetAllAnimals()
        {
            return context.Animals;
        }

        public Animal GetAnimal(int Id)
        {
           return context.Animals.Find(Id);
        }

        public Animal Update(Animal animalChanges)
        {
            var animal = context.Animals.Attach(animalChanges);
            animal.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return animalChanges;
        }
    }
}
