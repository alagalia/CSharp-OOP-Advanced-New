namespace _11.CreateCustomClassAttribute.Models.Weapons
{
    public class Axe : Weapon
    {
        private const int minDamage = 5;
        private const int maxDamage = 10;
        private const int sockeds = 4;

        public Axe(string name, LevelOfRarity levelOfRarity)
            : base(name, minDamage, maxDamage, sockeds, levelOfRarity)
        {
        }
    }
}