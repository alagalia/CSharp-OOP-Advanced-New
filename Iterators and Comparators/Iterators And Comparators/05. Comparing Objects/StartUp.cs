namespace _05.Comparing_Objects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            List<Person> persons = new List<Person>();

            while (line != "END")
            {
                string[] input = line.Split();

                int age = int.Parse(input[1]);
                Person p = new Person(input[0], age, input[2]);
                persons.Add(p);
                line = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine());
            Person target = persons[n-1];
            int matches = persons.Count(person => person.CompareTo(target) == 0);
            Console.WriteLine(
                matches == 1 ? "No matches" : $"{matches} {Math.Abs(matches - persons.Count)} {persons.Count}");
        }
    }

    public class Person : IComparable<Person>
    {

        public Person(string name, int age, string town)
        {
            this.Age = age;
            this.Name = name;
            this.Town = town;
        }

        private string Town { get;}

        private string Name { get;}

        private int Age { get; }

        public int CompareTo(Person other)
        {
            if (
                this.Name == other.Name &&
                this.Age == other.Age &&
                this.Town == other.Town)
            {
                return 0;
            }
            return -100;
        }
    }
}
