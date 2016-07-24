using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.GenericSwapMethodStrings
{
    using System.Runtime.InteropServices;

    public class GenericSwapMethodStrings
    {
        public static void Main()
        {
            List<Box<string>> myList = new List<Box<string>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());
                myList.Add(box);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Swap(myList, indexes[0], indexes[1]);

            foreach (var box in myList)
            {
                Console.WriteLine(box);
            }
        }

        private static void Swap<T>(List<Box<T>> myList, int firstIndex, int secondIndex)
        {
            Box<T> temp = myList[firstIndex];
            myList[firstIndex] = myList[secondIndex];
            myList[secondIndex] = temp;
        }
    }

    public class Box<T>
    {
        public Box(T value)
        {
            this.Value = value;
        }

        private T Value { get; set; }

        public override string ToString()
        {
            return this.Value.GetType().FullName + ": " + this.Value;
        }
    }

}
