using AnimalRestApi.Models;

namespace AnimalRestApi.Services;

public interface IAnimalService
{
    IEnumerable<Animal> GetAnimals(string orderBy);
    int AddAnimal(AnimalDto animal);
}