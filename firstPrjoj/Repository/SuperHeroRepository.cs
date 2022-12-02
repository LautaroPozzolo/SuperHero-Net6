using firstPrjoj.Data;
using firstPrjoj.Entities;
using Microsoft.EntityFrameworkCore;

namespace SuperHeroAPI.Repository
{
    public class SuperHeroRepository : ISuperHeroRepository
    {
        private readonly DataContext _context;
        public SuperHeroRepository(DataContext context)
        {
            this._context = context;
        }

        public List<SuperHero> GetAll()
        {
            return _context.superHeroes.ToList();
        }

        public SuperHero SuperHeroGetById(int id)
        {
            return _context.superHeroes.FirstOrDefault(x => x.Id == id);
        }

        public SuperHero Create(SuperHero super)
        {
            _context.superHeroes.Add(super);
            _context.SaveChanges();

            return super;
        }

        public SuperHero Update(SuperHero request)
        {
            _context.Entry(request).State = EntityState.Modified;
            _context.SaveChanges();

            return request;
        }

        public void Delete(int id)
        {
            var hero = _context.superHeroes.Find(id);

            _context.superHeroes.Remove(hero);
            _context.SaveChanges();
        }
    }
}
