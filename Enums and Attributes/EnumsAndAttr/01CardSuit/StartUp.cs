namespace _01CardSuit
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
           Suit[] s = { Suit.Clubs , Suit.Diamonds, Suit.Hearts, Suit.Spades };
            Console.WriteLine("Card Suits:");
            foreach (var suit in s)
            {
                Console.WriteLine($"Ordinal value: {(int)suit}; Name value: {suit}");
            }
        }
    }
}
