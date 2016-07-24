namespace _01.ListyIterator
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            ListyIterator<string> collection = new ListyIterator<string>();
            while (input != "END")
            {
                try
                {
                    CommandExecutor(input, collection);
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }
        }

        private static void CommandExecutor(string input, ListyIterator<string> collection)
        {
            List<string> elements = input.Split().ToList();
            input = elements[0];
            elements.RemoveAt(0);
            switch (input)
            {
                case "Create":
                    {
                        collection.Create(elements);
                        break;
                    }

                case "Move":
                    {
                        Console.WriteLine(collection.Move());
                        break;
                    }

                case "Print":
                    {
                        collection.Print();
                        break;
                    }

                case "PrintAll":
                    {
                        collection.PrintAll();
                        break;
                    }

                case "HasNext":
                    {
                        Console.WriteLine(collection.HasNext());
                        break;
                    }
            }
        }
    }

    public class ListyIterator<T> : IEnumerable<T>
    {
        private int count = 0;

        public ListyIterator()
        {
            this.Elements = new List<T>();
        }

        private List<T> Elements { get; set; }

        public void Create(List<T> inputCollection)
        {
            if (inputCollection.Count == 0)
            {
                throw new NullReferenceException("Invalid Operation!");
            }

            this.Elements = inputCollection;
        }

        public bool Move()
        {
            if (this.count == this.Elements.Count - 1)
            {
                return false;
            }

            this.count++;
            return true;
        }

        public bool HasNext()
        {
            return this.count + 1 < this.Elements.Count;
        }

        public void Print()
        {
            if (this.Elements.Count == 0)
            {
                throw new IndexOutOfRangeException("Invalid Operation!");
            }

            Console.WriteLine(this.Elements[this.count]);
        }   

        public void PrintAll()
        {
            if (this.Elements.Count == 0)
            {
                throw new IndexOutOfRangeException("Invalid Operation!");
            }

            Console.WriteLine(string.Join(" ", this.Elements));
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Elements.Count; i++)
            {
                yield return this.Elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
