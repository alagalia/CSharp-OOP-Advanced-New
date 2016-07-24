using System;

namespace _08.CustomList
{
    public class StartUp
    {
        public static void Main()
        {
            CustomList<string> myCollection = new CustomList<string>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                CommandExecutor(myCollection, input);
                input = Console.ReadLine();
            }
        }

        private static void CommandExecutor(CustomList<string> myCollection, string input)
        {
            string[] tokens = input.Split();
            switch (tokens[0])
            {
                case "Add":
                    {
                        var element = tokens[1];
                        myCollection.Add(element);
                        break;
                    }

                case "Remove":
                    {
                        int index = int.Parse(tokens[1]);
                        myCollection.Remove(index);
                        break;
                    }

                case "Contains":
                    {
                        var element = tokens[1];
                        Console.WriteLine(myCollection.Contains(element));
                        break;
                    }

                case "Swap":
                    {
                        int firstIndex = int.Parse(tokens[1]);
                        int secondIndex = int.Parse(tokens[2]);
                        myCollection.Swap(firstIndex, secondIndex);
                        break;
                    }

                case "Greater":
                    {
                        var element = tokens[1];
                        Console.WriteLine(myCollection.CountGreaterThan(element));
                        break;
                    }

                case "Max":
                    {
                        Console.WriteLine(myCollection.Max());
                        break;
                    }

                case "Min":
                    {
                        Console.WriteLine(myCollection.Min());
                        break;
                    }

                case "Sort":
                    {
                        myCollection.Sort();
                        break;
                    }

                case "Print":
                    {
                        myCollection.Print();
                        break;
                    }
            }
        }
    }
}
