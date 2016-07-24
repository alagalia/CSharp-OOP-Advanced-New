using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Stack
{
    using System.Collections;

    public class Program
    {
        public static void Main(string[] args)
        {
            var myStack = new MyStack<int>();

            while (true)
            {
                var command = Console.ReadLine();

                if (command.Equals("END"))
                {
                    break;
                }

                try
                {
                    if (command.StartsWith("Push"))
                    {
                        var elements = command.Substring(5)
                            .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToList();

                        myStack.Push(elements);
                    }
                    else if (command.Equals("Pop"))
                    {
                        myStack.Pop();
                    }
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }

            foreach (var element in myStack)
            {
                Console.WriteLine(element);
            }

            foreach (var element in myStack)
            {
                Console.WriteLine(element);
            }


        }
    }

    public class MyStack<T> : IEnumerable<T>
    {
        private List<T> elements;

        private int lastIndex;

        public MyStack()
        {
            this.Elements = new List<T>();
        }

        public List<T> Elements { get; }
        
        public void Push(List<T> elementsForPush)
        {
            foreach (var element in elementsForPush)
            {
                this.Elements.Add(element);
            }
        }

        public void Pop()
        {
            if (this.Elements.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            this.Elements.RemoveAt(this.Elements.Count - 1);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Elements.Count - 1; i >= 0; i--)
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
