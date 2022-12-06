using firstPrjoj.Entities;

namespace SuperHeroAPI.Model
{
    public class SuperPower
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Weakness { get; set; } = string.Empty;
        public SuperHero SuperHero { get; set; }
    }
}
