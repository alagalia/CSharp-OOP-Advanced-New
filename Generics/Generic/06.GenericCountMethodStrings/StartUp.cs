using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.GenericCountMethodStrings
{
    class StartUp
    {
        static void Main()
        {
            List<Box<string>> myList = new List<Box<string>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());
                myList.Add(box);
            }

            Box<string> elementForCompare = new Box<string>(Console.ReadLine());
            Console.WriteLine(GreaterThan(myList, elementForCompare));
        }

        static int GreaterThan<T>(List<Box<T>> elements, Box<T> comparableElement)
            where T : IComparable
        {
            return elements.Count(e => e.Value.CompareTo(comparableElement.Value) > 0);
        }
    }

    public class Box<T>
    {
        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; }

        public override string ToString()
        {
            return this.Value.GetType().FullName + ": " + this.Value;
        }
    }

}
