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
            return Ok(_service.SuperHeroGetById(id));
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
            _service.Delete(id);

            return Ok($"SuperHero {id} was deleted");
        }
    }
}
