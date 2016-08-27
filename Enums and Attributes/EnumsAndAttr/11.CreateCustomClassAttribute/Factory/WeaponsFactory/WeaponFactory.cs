using _11.CreateCustomClassAttribute.Contracts;
using _11.CreateCustomClassAttribute.Models.Weapons;

namespace _11.CreateCustomClassAttribute.Factory.WeaponsFactory
{
    public class WeaponFactory
    {
        private string name;
        private LevelOfRarity levelOfRarity;

        public WeaponFactory(string name, LevelOfRarity levelOfRarity)
        {
            this.name = name;
            this.levelOfRarity = levelOfRarity;
        }

        public Axe CreateAxe()
        {
            return new Axe(this.name, this.levelOfRarity);
        }

        public Knife CreateKnife()
        {
            return new Knife(this.name, this.levelOfRarity);
        }

        public Sword CreateSword()
        {
            return new Sword(this.name, this.levelOfRarity);
        }
    }
}