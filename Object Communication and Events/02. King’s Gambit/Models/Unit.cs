namespace _02.King_s_Gambit.Models
{
    public abstract class Unit
    {
        protected Unit(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public override string ToString()
        {
            return this.Name;
        }

    }
}