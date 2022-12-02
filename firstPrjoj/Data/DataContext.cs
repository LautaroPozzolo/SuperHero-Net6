using firstPrjoj.Entities;
using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Model;

namespace firstPrjoj.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) {}
        public DbSet<SuperHero> superHeroes { get; set; }
        public DbSet<SuperPower> superPowers { get; set; }
    }
}
