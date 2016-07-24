namespace _04.Froggy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Collections;

    public class StartUp
    {
        public static void Main()
        {
            List<int> stones = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Lake myLake = new Lake(stones);
            Console.WriteLine(String.Join(", ", myLake));
        }
    }

    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(List<int> stones)
        {
            this.stones = stones;
        }


        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i += 2)
            {
                yield return this.stones[i];
            }
            int startIndex = this.stones.Count;
            if (this.stones.Count % 2 == 0)
            {
                startIndex -= 1;
            }
            else
            {
                startIndex -= 2;
            }
            for (int i = startIndex; i >= 0; i -= 2)
            {
                yield return this.stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
