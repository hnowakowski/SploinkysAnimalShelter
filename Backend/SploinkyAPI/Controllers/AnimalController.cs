using Microsoft.AspNetCore.Mvc;
using SploinkyAPI.Models;

namespace SploinkyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalController : ControllerBase
    {
        private readonly ILogger<AnimalController> _logger;

        public AnimalController(ILogger<AnimalController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAnimals")]
        public IEnumerable<Animal> Get()
        {
            List<Animal> animals = new List<Animal>();
            string[] names = { "splinky", "dinky", "molly", "stinky", "pimpinky" };
            int[] tests = { 7, 8, 5, 4, 2 };
            for (int i = 0; i < tests.Length; i++)
            {
                animals.Add(new Cat(i, names[i], tests[i]));
            }
            return animals.ToArray();
        }
    }
}
