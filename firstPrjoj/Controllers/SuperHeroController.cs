using firstPrjoj.Entities;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Services.Contracts;

namespace firstPrjoj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroServices _service;

        public SuperHeroController(ISuperHeroServices service)
        {
            _service = service;
        }

        [HttpGet]
        [Route ("/getHeros")]
        public ActionResult<List<SuperHero>> GetHeros()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<SuperHero> GetHeroById(int id)
        {
            var hero = _service.SuperHeroGetById(id);

            if (hero != null)
            {
                return Ok(hero);
            }
            else
            {
                return NotFound($"The super hero {id} does not exist");
            }
        }

        [HttpPost]
        public ActionResult<List<SuperHero>> AddHero(SuperHero hero)
        {
            return Ok(_service.Create(hero));
        }

        [HttpPut]
        public ActionResult<List<SuperHero>> UpdateHero(SuperHero request)
        {
            return Ok(_service.Update(request));
        }

        [HttpDelete("{id}")]
        public ActionResult<List<SuperHero>> DeleteHero(int id)
        {
            var heroToDelete = _service.SuperHeroGetById(id);

            if (heroToDelete != null)
            {
                _service.Delete(id);
                return Ok($"SuperHero {id} was deleted");
            }
            else
            {
                return NotFound($"The super hero {id} does not exist");
            }
        }
    }
}
