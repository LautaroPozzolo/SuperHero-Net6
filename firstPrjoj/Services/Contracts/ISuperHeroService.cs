using firstPrjoj.Entities;

namespace SuperHeroAPI.Services.Contracts
{
    public interface ISuperHeroServices
    {
        List<SuperHero> GetAll();
        SuperHero SuperHeroGetById(int id);
        SuperHero Create(SuperHero super);
        SuperHero Update(SuperHero super);
        void Delete(int id);
    }
}
