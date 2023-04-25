using test.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace test.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {


        private readonly ApplicationDbContext _context;

        public NameController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Animal> GetAnimals()
        {
            var names = _context.Roles.Take(2).ToList();

            //var newAnimal = new Animal() { Id = 1, Name = "khar", Type = "چهار پایان" };

            //var newListOfAnimal = new List<Animal>() {
               
            //    new Animal() { Id = 2, Name = "khar", Type = "چهار پایان" },
            //    new Animal() { Id = 3, Name = "khar", Type = "چهار پایان" },
            //    new Animal() { Id = 4, Name = "khar", Type = "چهار پایان" },
            //    new Animal() { Id = 5, Name = "khar", Type = "چهار پایان" },
                

            //};

            //_context.Animals.Add(newAnimal);

            //_context.Animals.AddRange(newListOfAnimal);
            //_context.SaveChanges();

            var animals = _context.Animals.ToList();


            //var user2 = _context.Users.FirstOrDefault();
            //var users = _context.Users.LastOrDefault();
            return animals;
        }

        [HttpPost]
        public List<Animal> CreateAnimal([FromBody]Animal animal)
        {


            _context.Animals.Add(animal);


            _context.SaveChanges();

            var animals = _context.Animals.ToList();


            return animals;
        }
    }
}
