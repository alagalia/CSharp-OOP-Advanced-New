using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GenericSwapMethodIntegers
{
    public class StartUp
    {
        static void Main()
        {
            var myList = new List<Box<int>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
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
