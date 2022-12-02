using firstPrjoj.Entities;

namespace SuperHeroAPI.Repository
{
    public interface ISuperHeroRepository
    {
        List<SuperHero> GetAll();
        SuperHero SuperHeroGetById(int id);
        SuperHero Create(SuperHero super);
        SuperHero Update(SuperHero super);
        void Delete(int id);
    }
}
