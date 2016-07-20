namespace _08.MilitaryElite.Models
{
    using _08.MilitaryElite.Interfaces;

    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstname, string lastName, int codeNumber)
            : base(id, firstname, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; }

        public override string ToString()
        {
            return base.ToString() + $"\nCode Number: {this.CodeNumber}";
        }
    }

}