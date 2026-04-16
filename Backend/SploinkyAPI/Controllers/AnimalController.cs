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
            return null;
        }


    }
}
