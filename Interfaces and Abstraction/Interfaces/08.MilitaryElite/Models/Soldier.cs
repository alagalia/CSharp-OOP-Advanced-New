namespace _08.MilitaryElite.Models
{
    using _08.MilitaryElite.Interfaces;

    public abstract class Soldier : ISoldier
    {
        protected Soldier(int id, string firstname, string lastName)
        {
            this.Id = id;
            this.Firstname = firstname;
            this.LastName = lastName;
        }

        public int Id { get; }

        public string Firstname { get; }

        public string LastName { get; }

        public override string ToString()
        {
            return $"Name: {this.Firstname} {this.LastName} Id: {this.Id}";
        }
    }

}