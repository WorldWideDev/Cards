using System.Collections.Generic;
using System;
namespace CardGame.Models
{
    public class CardDeck
    {
        public List<Card> Deck {get; private set;}
        public CardDeck()
        {
            Reset();
        }
        public void Reset()
        {
            Deck = new List<Card>();
            // i => suit idx [clubs, diamonds, hearts, spades]
            for(short i=0; i<4; i++)
            {

                // j => card values (1 - 13)
                for(short j=1; j<14; j++)
                {
                    Card card = new Card(i, j);
                    Deck.Add(card);
                }
            }

        }
        public Card Deal() 
        {
            if(Deck.Count < 1) throw new KeyNotFoundException("Can not deal from empty deck!");
            Card card = Deck[0];
            Deck.RemoveAt(0);
            return card;
        }
        public void Shuffle()
        {
            int start = Deck.Count-1;
            Random r = new Random();
            for(int i=start; i>0; i--)
            {
                int swap = r.Next(0, i+1);
                var temp = Deck[swap];
                Deck[swap] = Deck[i];
                Deck[i] = temp;
            }
        }
    }
}
