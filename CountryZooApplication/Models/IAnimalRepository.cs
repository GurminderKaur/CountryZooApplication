using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryZooApplication.Models
{
    public interface IAnimalRepository
    {
        Animal GetAnimal(int Id);
        IEnumerable<Animal> GetAllAnimals();
        Animal Add(Animal animal);
        Animal Update(Animal animalChanges);
        Animal Delete(int Id);
    }
}
