namespace _03.CardPower
{
    using System;

    public class Card : IComparable<Card>
    {
        public Card(string cardSuit, string cardRank) 
        {
            this.CardSuit = cardSuit;
            this.CardRank = cardRank;
        }

        private int CardPower()
        {
            return (int)Enum.Parse(typeof(Suit), this.CardSuit) + (int)Enum.Parse(typeof(Rank), this.CardRank);
        }

        public string CardRank { get; private set; }

        public string CardSuit { get; private set; }
        
        public override string ToString()
        {
            return $"Card name: {this.CardRank} of {this.CardSuit}; Card power: {this.CardPower()}";
        }
        
        public int CompareTo(Card another)
        {
            return this.CardPower() - another.CardPower();
        }
    }
}   