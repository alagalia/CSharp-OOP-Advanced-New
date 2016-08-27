namespace _11.CreateCustomClassAttribute.Models.Gems
{
    public class Ruby : Gem
    {
        private const int strength = 7;
        private const int agility = 2;
        private const int vitality = 5;

        public Ruby(GemClarities gemClarities) : 
            base(gemClarities, strength, agility, vitality)
        {
        }
    }
}