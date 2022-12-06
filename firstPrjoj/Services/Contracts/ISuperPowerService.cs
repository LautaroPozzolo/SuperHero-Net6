using SuperHeroAPI.Model;

namespace SuperHeroAPI.Services.Contracts
{
    public interface ISuperPowerService
    {
        List<SuperPower> GetAll();
        SuperPower SuperPowerGetById(int id);
        List<SuperPower> SuperPowerGetByHeroId(int id);
        SuperPower Create(SuperPower power);
        SuperPower Update(SuperPower power);
        void Delete(int id);
    }
}
