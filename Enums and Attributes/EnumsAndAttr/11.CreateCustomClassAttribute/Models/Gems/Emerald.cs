namespace _11.CreateCustomClassAttribute.Models.Gems
{
    public class Emerald :Gem
    {
        private const int strength = 1;
        private const int agility = 4;
        private const int vitality = 9;

        public Emerald(GemClarities gemClarities) : 
            base(gemClarities, strength, agility, vitality)
        {
        }
    }
}