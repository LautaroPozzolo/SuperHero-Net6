using SuperHeroAPI.Model;

namespace SuperHeroAPI.Repository.Interfaces
{
    public interface ISuperPowerRepository
    {
        List<SuperPower> GetAll();
        SuperPower SuperPowerGetById(int id);
        List<SuperPower> SuperPowerGetByHeroId(int id);
        SuperPower Create(SuperPower power);
        SuperPower Update(SuperPower power);
        void Delete(int id);
    }
}
