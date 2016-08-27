using System.Collections.Generic;
using _11.CreateCustomClassAttribute.Models.Weapons;

namespace _11.CreateCustomClassAttribute.Repository
{
    public class WeaponRepository
    {   
        private IDictionary<string, Weapon> repo;

        public WeaponRepository()
        {
            this.repo = new Dictionary<string, Weapon>();
        }

        public void AddToRepository(string name, Weapon weapon)
        {
            repo.Add(name, weapon);
        }

        public void RemoveFromRepository(string name)
        {
            repo.Remove(name);
        }

        public Weapon GetFormRepository(string name)
        {
            return repo[name];
        }
    }
}