namespace _11.CreateCustomClassAttribute.Models.Weapons
{
    public class Sword : Weapon
    {
        private const int minDamage = 4;
        private const int maxDamage = 6;
        private const int sockeds = 3;

        public Sword(string name, LevelOfRarity levelOfRarity) : base(name, minDamage, maxDamage, sockeds, levelOfRarity)
        {
        }
    }
}