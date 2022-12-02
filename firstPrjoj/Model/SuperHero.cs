using System.ComponentModel.DataAnnotations;

namespace firstPrjoj.Entities
{
    public class SuperHero
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string SuperPower { get; set; }
        #endregion

    }
}
