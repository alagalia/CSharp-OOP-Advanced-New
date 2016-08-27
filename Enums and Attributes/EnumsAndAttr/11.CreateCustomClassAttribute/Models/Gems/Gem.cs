namespace _11.CreateCustomClassAttribute.Models.Gems
{
    public abstract class Gem
    {
        private int strength;
        private int agility;
        private int vitality;
        private GemClarities gemClarities;

        protected Gem(GemClarities gemClarities, int strength, int agility, int vitality)
        {
            this.gemClarities = gemClarities;
            this.Strength = strength;
            this.Agility = agility;
            this.Vitality = vitality;
        }

        public int Strength
        {
            get { return this.strength; }
            set { this.strength = value * (int)this.gemClarities; }
        }

        public int Agility
        {
            get { return this.agility; }
            set { this.agility = value * (int)this.gemClarities; }
        }

        public int Vitality
        {
            get { return this.vitality; }
            set { this.vitality = value * (int)this.gemClarities; }

        }
    }
}