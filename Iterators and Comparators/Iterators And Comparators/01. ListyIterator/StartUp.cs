namespace _01.ListyIterator
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
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
}
