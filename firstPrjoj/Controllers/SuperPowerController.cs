using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Model;
using SuperHeroAPI.Services.Contracts;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperPowerController : Controller
    {
        private readonly ISuperPowerService _service;
        private readonly ISuperHeroServices _heroService;

        public SuperPowerController(ISuperPowerService service, ISuperHeroServices heroServices)
        {
            _service = service;
            _heroService = heroServices;
        }

        [HttpGet]
        [Route("/getPowers")]
        public async Task<ActionResult<List<SuperPower>>> GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperPower>> GetPowerById(int id) 
        {
            var power = _service.SuperPowerGetById(id);

            if (power != null)
            {
                return Ok(power);
            }
            else
            {
                return NotFound($"The super power {id} does not exist");
            }
        }

        [HttpGet("superhero/{heroId}")]
        public async Task<ActionResult<SuperPower>> GetPowerByHeroId(int heroId)
        {
            var power = _service.SuperPowerGetByHeroId(heroId);

            if (power != null)
            {
                return Ok(power);
            }
            else
            {
                return NotFound($"There is no super power for the hero id: {heroId}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<SuperPower>> AddPower(SuperPower superPower) 
        {
            var hero = _heroService.SuperHeroGetById(superPower.SuperHeroId);

            if (hero != null) 
            {
                return Ok(_service.Create(superPower));
            }

            return NotFound($"The heroId: {superPower.SuperHeroId} does not exist in database");
        }

        [HttpPut]
        public async Task<ActionResult<SuperPower>> UpdatePower(SuperPower superPower)
        {
            var hero = _heroService.SuperHeroGetById(superPower.SuperHeroId);

            if (hero != null)
            {
                return Ok(_service.Update(superPower));
            }


            return NotFound($"The heroId: {superPower.SuperHeroId} does not exist in database");
        }

        [HttpDelete]
        public async Task<ActionResult> DeletePower(int id)
        {
            var powerToDelete = _service.SuperPowerGetById(id);

            if (powerToDelete != null)
            {
                _service.Delete(id);
                return Ok($"SuperPower {id} was deleted");
            }
            else
            {
                return NotFound($"The super power {id} does not exist");
            }
        }
    }
}
