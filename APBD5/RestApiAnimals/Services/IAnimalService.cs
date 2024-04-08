using RestApiAnimals.Models;

namespace RestApiAnimals.Services;

public interface IAnimalService
{
    IEnumerable<Animal> GetAnimals();
    Animal? GetAnimal(int animalId);
    int CreateAnimal(Animal animal);
    int UpdateAnimal(Animal animal);
    int DeleteAnimal(int animalId);
}