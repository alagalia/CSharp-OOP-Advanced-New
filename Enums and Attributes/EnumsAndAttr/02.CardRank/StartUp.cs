using System;

namespace _02.CardRank
{
    public class StartUp
    {
        public static void Main()
        {
            var values = Enum.GetValues(typeof(Card));
            Console.WriteLine("Card Ranks:");
            foreach (var val in values)
            {
                Console.WriteLine($"Ordinal value: {(int)val}; Name value: {val}");
            }
        }
    }
}
