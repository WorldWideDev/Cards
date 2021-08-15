using System;
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
            Card card = deck.Deal(); 
            Console.WriteLine(card.DisplayValue);
            CardRenderer.Render(card);
        }
    }
}
