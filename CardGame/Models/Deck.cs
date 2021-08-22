using System.Collections.Generic;
namespace CardGame.Models
{
    public class CardDeck
    {
        public List<Card> Deck {get; private set;}
        public CardDeck()
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
            if(Deck.Count < 1) throw new KeyNotFoundException();
            Card card = Deck[0];
            Deck.RemoveAt(0);
            return card;
        }
    }
}
