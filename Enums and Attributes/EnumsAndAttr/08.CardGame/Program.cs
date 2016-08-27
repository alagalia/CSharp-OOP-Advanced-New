namespace _08.CardGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var suits = Enum.GetValues(typeof(Suit));
            var ranks = Enum.GetValues(typeof(Rank));
            var originalDeck = new List<string>();
            var modifiedDeck = new List<string>();

            foreach (Suit suit in suits)
            {
                foreach (Rank rank in ranks)
                {
                    originalDeck.Add($"{rank} of {suit}");
                    modifiedDeck.Add($"{rank} of {suit}");
                }
            }

            string firstPlayerName = Console.ReadLine();
            List<Card> firstPlayerDeck = new List<Card>();
            int firstPlayerHands = 0;

            string secondPlayerName = Console.ReadLine();
            List<Card> secondPlayerDeck = new List<Card>();
            int secondPlayerHands = 0;

            while (true)
            {
                string inputHand = Console.ReadLine();
                if (modifiedDeck.Contains(inputHand))
                {
                    Card card = ConvertToCard(inputHand);
                    firstPlayerDeck.Add(card);
                    modifiedDeck.Remove(inputHand);
                    firstPlayerHands++;
                }
                else
                {
                    WriteError(originalDeck, inputHand);
                }

                if (firstPlayerHands == 5)
                {
                    break;
                }
            }

            while (true)
            {
                string inputHand = Console.ReadLine();
                if (modifiedDeck.Contains(inputHand))
                {
                    Card card = ConvertToCard(inputHand);
                    secondPlayerDeck.Add(card);
                    modifiedDeck.Remove(inputHand);
                    secondPlayerHands++;
                }
                else
                {
                    WriteError(originalDeck, inputHand);
                }

                if (secondPlayerHands == 5)
                {
                    break;
                }
            }

            Card firstPlayerLargest = firstPlayerDeck.OrderByDescending(i => i.CardPower()).FirstOrDefault();
            Card secondPlayerLargest = secondPlayerDeck.OrderByDescending(i => i.CardPower()).FirstOrDefault();

            Console.WriteLine(firstPlayerLargest.CardPower() > secondPlayerLargest.CardPower() ? 
                $"{firstPlayerName} wins with {firstPlayerLargest}." : 
                $"{secondPlayerName} wins with {secondPlayerLargest}.");
        }

        private static void WriteError(List<string> originalDeck, string inputHand)
        {
            Console.WriteLine(originalDeck.Contains(inputHand) ? "Card is not in the deck." : "No such card exists.");
        }

        private static Card ConvertToCard(string inputHand)
        {
            string[] handInfo = inputHand.Split(' ');
            string rank = handInfo[0];
            string suit = handInfo[2];
            Card card = new Card((Suit) Enum.Parse(typeof(Suit), suit), (Rank) Enum.Parse(typeof(Rank), rank));
            return card;
        }
    }
}
