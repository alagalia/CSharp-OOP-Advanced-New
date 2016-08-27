namespace _11.CreateCustomClassAttribute.Models.Weapons
{
    public class Knife : Weapon
    {
        private const int minDamage = 3;
        private const int maxDamage = 4;
        private const int sockeds = 2;

        public Knife(string name, LevelOfRarity levelOfRarity) : base(name, minDamage, maxDamage, sockeds, levelOfRarity)
        {
        }
    }
}