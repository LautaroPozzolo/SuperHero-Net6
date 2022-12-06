using SuperHeroAPI.Model;
using System.ComponentModel.DataAnnotations;

namespace firstPrjoj.Entities
{
    public class SuperHero
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public List<SuperPower> SuperPowers { get; set; }
        #endregion

    }
}
