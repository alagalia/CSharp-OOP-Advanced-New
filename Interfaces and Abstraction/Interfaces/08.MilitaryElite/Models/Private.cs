namespace _08.MilitaryElite.Models
{
    using _08.MilitaryElite.Interfaces;

    public class Private : Soldier, IPrivate
    {
        public Private(int id, string firstname, string lastName, double salary)
            : base(id, firstname, lastName)
        {
            this.Salary = salary;
        }

        public double Salary { get; }

        public override string ToString()
        {
            return base.ToString() + $" Salary: {this.Salary:F2}";
        }
    }

}