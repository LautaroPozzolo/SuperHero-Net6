using firstPrjoj.Data;
using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Model;
using SuperHeroAPI.Repository.Interfaces;

namespace SuperHeroAPI.Repository
{
    public class SuperPowerRepository : ISuperPowerRepository
    {

        private readonly DataContext _context;

        public SuperPowerRepository(DataContext context) 
        { 
            _context = context;
        }

        public SuperPower Create(SuperPower power)
        {
            _context.superPowers.Add(power);
            _context.SaveChanges();

            return power;
        }

        public void Delete(int id)
        {
            var power = _context.superPowers.Find(id);

            if (power != null)
            {
                _context.superPowers.Remove(power);
                _context.SaveChanges();
            }
        }

        public List<SuperPower> GetAll()
        {
            return _context.superPowers.ToList();
        }

        public List<SuperPower> SuperPowerGetByHeroId(int id)
        {
            return _context.superPowers.Where(p => p.SuperHeroId == id).ToList();
        }

        public SuperPower SuperPowerGetById(int id)
        {
            return _context.superPowers.Find(id);
        }

        public SuperPower Update(SuperPower request)
        {
            _context.Entry(request).State = EntityState.Modified;
            _context.SaveChanges();

            return request;
        }
    }
}
