using _11.CreateCustomClassAttribute.Models.Gems;

namespace _11.CreateCustomClassAttribute.Models.Weapons
{
    public abstract class Weapon
    {
        private const int startStats = 0;
        private string name;
        private int minDamage;
        private int maxDamage;
        private int sockets;
        
        private int strength;
        private int agility;
        private int vitality;

        protected Weapon(string name, int minDamage, int maxDamage, int sockets, LevelOfRarity levelOfRarity)
        {
            this.Name = name;
            this.LevelOfRarity = levelOfRarity;
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
            this.Sockets = sockets;

            this.strength = startStats;
            this.agility = startStats;
            this.vitality = startStats;
        }

        public string Name { get; set; }

        public int MinDamage
        {
            get { return this.minDamage*(int) LevelOfRarity; }
            set { this.minDamage = value; }
        }

        public int MaxDamage
        {
            get { return this.maxDamage * (int)LevelOfRarity; }
            set { this.maxDamage = value; }
        }

        public int Sockets { get; }

        public LevelOfRarity LevelOfRarity { get; }

        public void AddGem(Gem gem)
        {
            this.agility += gem.Agility;
            this.strength += gem.Strength;
            this.vitality += gem.Vitality;
        }

        public override string ToString()
        {
            return
                $"{this.name}: {this.minDamage}-{this.maxDamage} Damage, +{this.strength} Strength, +{this.agility} Agility, +{this.vitality} Vitality";
        }
    }
}
