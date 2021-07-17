using System.Collections.Generic;
namespace CardGame.Models
{
    public class Deck
    {
        public List<Card> Deck {get; private set;}
        public Deck()
        {
            Deck = new Deck();
            for(int i=0; i<4; i++)
            {

                for(int j=0; j<13; j++)
                {
                    Deck.Add(new Card(i, j));
                }
            }
        }
    }
}
