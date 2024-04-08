using Microsoft.AspNetCore.Mvc;
using RestApiAnimals.Models;
using RestApiAnimals.Services;

namespace RestApiAnimals.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnimalsController : ControllerBase
{
    private IAnimalService _animalService;

    public AnimalsController(IAnimalService animalService)
    {
        _animalService = animalService;
    }

    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = _animalService.GetAnimals();
        return Ok(animals);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = _animalService.GetAnimal(id);
        if (animal == null)
        {
            return StatusCode(StatusCodes.Status404NotFound);
        }

        return Ok(animal);
    }

    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        _animalService.CreateAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        int status = _animalService.DeleteAnimal(id);
        if (status == 1)
        {
            return NoContent();
        }
        return StatusCode(StatusCodes.Status404NotFound);
    }

    [HttpPut]
    public IActionResult UpdateAnimal(Animal animal)
    {
       int status = _animalService.UpdateAnimal(animal);
       if (status == 1)
       {
           return Ok();
       }

       return StatusCode(StatusCodes.Status404NotFound);
    }
    
}