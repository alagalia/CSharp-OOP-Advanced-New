namespace _08.CustomList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomList<T>
        where T : IComparable
    {
        private List<T> elements;

        public CustomList()
        {
            this.elements = new List<T>();
        }

        public void Add(T element)
        {
            this.elements.Add(element);
        }

        public T Remove(int index)
        {
            this.ValidateIndex(index);
            T removed = this.elements[index];
            this.elements.RemoveAt(index);
            return removed;
        }

        public bool Contains(T element)
        {
            return this.elements.Contains(element);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            this.ValidateIndex(firstIndex, secondIndex);
            T temp = this.elements[firstIndex];
            this.elements[firstIndex] = this.elements[secondIndex];
            this.elements[secondIndex] = temp;
        }

        public int CountGreaterThan(T element)
        {
            return this.elements.Count(e => e.CompareTo(element) > 0);
        }

        public T Max()
        {
            return this.elements.Max();
        }

        public T Min()
        {
            return this.elements.Min();
        }

        public void Print()
        {
            this.elements.ForEach(e => Console.WriteLine(e));
        }

        public void Sort()
        {
            this.elements = this.elements.OrderBy(e => e).ToList();
        }

        private void ValidateIndex(params int[] indices)
        {
            foreach (int index in indices)
            {
                if (index >= this.elements.Count || index < 0)
                {
                    throw new IndexOutOfRangeException("Index is outside of range!");
                }
            }
        }
    }
}