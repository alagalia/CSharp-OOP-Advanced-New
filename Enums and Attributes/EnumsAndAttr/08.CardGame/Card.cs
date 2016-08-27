using System;

namespace _08.CardGame
{
    public class Card : IComparable<Card>
    {
        public Card(Suit cardSuit, Rank cardRank) 
        {
            this.CardSuit = cardSuit;
            this.CardRank = cardRank;
        }

        public int CardPower()
        {
            return (int)this.CardSuit + (int)this.CardRank;
        }

        public Rank CardRank { get; private set; }

        public Suit CardSuit { get; private set; }
        
        public override string ToString()
        {
            return $"{this.CardRank} of {this.CardSuit}";
        }
        
        public int CompareTo(Card another)
        {
            return this.CardPower() - another.CardPower();
        }
    }
}   