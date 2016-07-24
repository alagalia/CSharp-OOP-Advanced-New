using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Generic_Count_Method_Doubles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Box<double>> myList = new List<Box<double>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var box = new Box<double>(double.Parse(Console.ReadLine()));
                myList.Add(box);
            }

            var elementForCompare = new Box<double>(double.Parse(Console.ReadLine()));
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
