namespace _06.CustomEnumAttribute
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            if (input.Equals("Rank"))
            {
                var attributes = typeof(Rank).GetCustomAttributes(false);

                foreach (TypeAttribute attr in attributes)
                {
                    Console.WriteLine(attr);
                }
            }
            else
            {
                var attributes = typeof(Suit).GetCustomAttributes(false);

                foreach (TypeAttribute attr in attributes)
                {
                    Console.WriteLine(attr);
                }
            }
        }
    }
}
