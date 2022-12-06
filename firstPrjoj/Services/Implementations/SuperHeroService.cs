using firstPrjoj.Data;
using firstPrjoj.Entities;
using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Repository.Interfaces;
using SuperHeroAPI.Services.Contracts;

namespace SuperHeroAPI.Services.Implementations
{
    public class SuperHeroService : ISuperHeroServices
    {
        private readonly ISuperHeroRepository _repository;

        public SuperHeroService(ISuperHeroRepository repository)
        {
            _repository = repository;
        }

        public SuperHero Create(SuperHero super)
        {
            return _repository.Create(super);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<SuperHero> GetAll()
        {
            return _repository.GetAll();
        }

        public SuperHero SuperHeroGetById(int id)
        {
            return _repository.SuperHeroGetById(id);
        }

        public SuperHero Update(SuperHero super)
        {
            return _repository.Update(super);
        }
    }
}
