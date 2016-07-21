namespace _10.ExplicitInterfaces.Models
{
    using _10.ExplicitInterfaces.Interfaces;

    public class Citizen : IPerson, IResident
    {
        public Citizen(string name, int age, string country)
        {
            this.Name = name;
            this.age = age;
            this.Country = country;
        }

        public string Name { get; }

        public int age { get; }

        public string Country { get; }

        string IResident.GetName()
        {
            return "Mr/Ms/Mrs " + this.Name;
        }

        string IPerson.GetName()
        {
            return this.Name;
        }
    }
}