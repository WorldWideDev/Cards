using System;
using System.Text;
using CardGame.Views.Utilities;
using CardGame.Models;
namespace CardGame.Views
{
    public static class CardRenderer
    {
        public static void Render(Card card)
        {
            Render(card, CardSize.Small);
        }
        // private static int xSpacing = 1;
        // private static int xOffset = xSpacing * 2;
        public static void Render(Card card, CardSize size)
        {
            CardDimension dimension = new CardDimension(size);
            // int rowLen = (dimension.Width * 2)%2==0 ? dimension.Width*2-1 : dimension.Width*2;
            int rowLen = dimension.Width;
            int colLen = dimension.Length;
            for(int y = 0; y < colLen; ++y)
            {
                StringBuilder str = new StringBuilder();
                for(int x = 0; x < rowLen; ++x)
                {
                    GridPosition position = new GridPosition(x, rowLen, y, colLen);
                    // render border if top/bottom row OR left/right column
                    if(renderBorder(x, y, dimension))
                        str.Append(CardCharacters.Border);
                    
                    else if(renderSuit(x, y, dimension))
                        str.Append(suitCharacter(card.Suit));
                    else if(renderValue(x, y, dimension))
                        str.Append(card.DisplayValueShort);
                    else
                        str.Append(' ');
                }
                Console.WriteLine(str.ToString());
            }
        }
        
        private static bool renderBorder(int x, int y, CardDimension card) => 
            // if top/bottom row render every other column
            (x == 0 || x == card.Width - 1) || 
            x%card.SizeMultiplier==0 && (y == 0 || y == card.Length - 1);
        
        private static bool renderSuit(int x, int y, CardDimension card) =>
            (y == card.SizeMultiplier && x == card.SizeMultiplier) ||
            (y == card.Length - 1 - card.SizeMultiplier && x == card.Width - 1 - card.SizeMultiplier);
        
        private static bool renderValue(int x, int y, CardDimension card) =>
            (y == card.SizeMultiplier && x == card.Width - 1 - card.SizeMultiplier) ||
            (y == card.Length - 1 - card.SizeMultiplier && x == card.SizeMultiplier);

        private static char suitCharacter(string suit)
        {
            switch(suit)
            {
                case "Spades":
                    return CardCharacters.Spade;
                case "Hearts":
                    return CardCharacters.Heart;
                case "Diamonds":
                    return CardCharacters.Diamond;
                default:
                    return CardCharacters.Club;
            }
        }
    }
}
