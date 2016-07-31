namespace _03.Dependency_Inversion
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            PrimitiveCalculator calc = new PrimitiveCalculator(new AdditionStrategy());
            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input.StartsWith("mode"))
                {
                    char @operator = input.Split()[1][0];
                    calc.ChangeStrategy(@operator);
                    input = Console.ReadLine();
                }

                int[] tokens = input.Split().Select(int.Parse).ToArray();
                Console.WriteLine(calc.PerformCalculation(tokens[0], tokens[1]));
                input = Console.ReadLine();
            }
        }
    }
}
