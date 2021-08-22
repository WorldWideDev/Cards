using System;
using System.Collections.Generic;
using CardGame.Models;
using CardGame.Views;
using CardGame.Views.Utilities;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {

            CardDeck deck = new CardDeck();
            
            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine(deck.Deck[i].DisplayValue);
                CardRenderer.Render(deck.Deck[i], CardSize.Medium);
            }
        }
    }
}
