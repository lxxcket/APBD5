using RestApiAnimals.Models;
using RestApiAnimals.Repositories;

namespace RestApiAnimals.Services;

public class AnimalService : IAnimalService
{
    private readonly IAnimalRepository _animalRepository;

    public AnimalService(IAnimalRepository animalRepository)
    {
        _animalRepository = animalRepository;
    }
    public IEnumerable<Animal> GetAnimals()
    {
        return _animalRepository.GetAnimals();
    }

    public Animal? GetAnimal(int animalId)
    {
        return _animalRepository.GetAnimal(animalId);
    }

    public int CreateAnimal(Animal animal)
    {
        return _animalRepository.CreateAnimal(animal);
    }

    public int UpdateAnimal(Animal animal)
    {
        return _animalRepository.UpdateAnimal(animal);
    }

    public int DeleteAnimal(int animalId)
    {
        
        return _animalRepository.DeleteAnimal(animalId);
    }
}