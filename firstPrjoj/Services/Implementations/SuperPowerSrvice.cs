using SuperHeroAPI.Model;
using SuperHeroAPI.Repository.Interfaces;
using SuperHeroAPI.Services.Contracts;

namespace SuperHeroAPI.Services.Implementations
{
    public class SuperPowerSrvice : ISuperPowerService
    {
        private readonly ISuperPowerRepository _repository;
        public SuperPowerSrvice(ISuperPowerRepository repository) 
        {
            _repository = repository;
        }
        public SuperPower Create(SuperPower power)
        {
            return _repository.Create(power);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<SuperPower> GetAll()
        {
            return _repository.GetAll();
        }

        public List<SuperPower> SuperPowerGetByHeroId(int id)
        {
            return _repository.SuperPowerGetByHeroId(id);
        }

        public SuperPower SuperPowerGetById(int id)
        {
            return _repository.SuperPowerGetById(id);
        }

        public SuperPower Update(SuperPower power)
        {
            return _repository.Update(power);
        }
    }
}
