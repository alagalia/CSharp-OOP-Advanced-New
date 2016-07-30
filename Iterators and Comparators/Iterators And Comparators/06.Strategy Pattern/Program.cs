using System;
using System.Collections.Generic;

namespace _06.Strategy_Pattern
{
   
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> byAge = new SortedSet<Person>(new AgeComparer());
            SortedSet<Person> byName = new SortedSet<Person>(new NameComparer());

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Person p = new Person(input[0], int.Parse(input[1]));
                byAge.Add(p);
                byName.Add(p);
            }

            foreach (var person in byName)
            {
                Console.WriteLine(person);
            }

            foreach (var person in byAge)
            {
                Console.WriteLine(person);
            }
        }
    }

    public class NameComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Name.Length == y.Name.Length)
            {
                return string.Compare(x.ToString(), y.ToString(), StringComparison.OrdinalIgnoreCase);
            }
            return x.Name.Length.CompareTo(y.Name.Length);
        }
    }

    public class AgeComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
    public class Person
    {
        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }

        internal string Name { get; }

        internal int Age { get; }


        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }

}
