using firstPrjoj.Data;
using firstPrjoj.Entities;
using Microsoft.AspNetCore.Mvc;

namespace firstPrjoj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly DataContext _context;

        public SuperHeroController(DataContext context)
        {
            _context= context;
        }

        [HttpGet]
        public ActionResult<List<SuperHero>> GetHeros()
        {
            return Ok(_context.superHeroes.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<SuperHero> GetHeroById(int id)
        {
            var hero = _context.superHeroes.Find(id);

            if (hero == null)
                return BadRequest("Hero not found");

            return Ok(hero);
        }

        [HttpPost]
        public ActionResult<List<SuperHero>> AddHero(SuperHero hero)
        {
            _context.superHeroes.Add(hero);
            _context.SaveChanges();

            return Ok(_context.superHeroes.ToList());
        }

        [HttpPut]
        public ActionResult<List<SuperHero>> UpdateHero(SuperHero request)
        {
            var hero = _context.superHeroes.Find(request.Id);

            if (hero == null)
                return BadRequest("Hero not found");

            hero.Name = request.Name;
            hero.LastName = request.LastName;
            hero.SuperPower = request.SuperPower;
            hero.Age= request.Age;

            _context.SaveChanges();

            return Ok(_context.superHeroes.ToList());
        }

        [HttpDelete("{id}")]
        public ActionResult<List<SuperHero>> DeleteHero(int id)
        {
            var hero = _context.superHeroes.Find(id);

            if (hero == null)
                return BadRequest("Hero not found");

            _context.superHeroes.Remove(hero);
            _context.SaveChanges();

            return Ok(_context.superHeroes.ToList());
        }
    }
}
