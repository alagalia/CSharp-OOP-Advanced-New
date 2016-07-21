using System;

namespace _02.Multiple_Implementation
{
    using System.Reflection;

    public class MultipleImplementation
    {   
        public static void Main()
        {
            Type identifiableInterface = typeof(Citizen).GetInterface("IIdentifiable");
            Type birthableInterface = typeof(Citizen).GetInterface("IBirthable");
            PropertyInfo[] properties = identifiableInterface.GetProperties();
            Console.WriteLine(properties.Length);
            Console.WriteLine(properties[0].PropertyType.Name);
            properties = birthableInterface.GetProperties();
            Console.WriteLine(properties.Length);
            Console.WriteLine(properties[0].PropertyType.Name);
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();
            IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
            IBirthable birthable = new Citizen(name, age, id, birthdate);
        }
    }

    public interface IPerson
    {
        string Name { get; }
        int Age { get; }
    }

    public interface IIdentifiable
    {
        string Id { get; }
    }

    public interface IBirthable
    {
        string Birthdate { get; }
    }

    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        private string name;

        private int age;

        private string id;

        private string birthdate;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.birthdate = birthdate;
        }

        public string Name => this.name;

        public int Age => this.age;

        public string Id => this.id;

        public string Birthdate => this.birthdate;
    }
}   
