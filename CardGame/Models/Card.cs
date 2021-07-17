namespace CardGame.Models
{
    public class Card
    {
        private static string[] suits = {"Clubs", "Diamonds", "Hearts", "Spades" };
        public string Suit {get; private set;}
        public static short Value {get; private set;}
        public Card(int sIdx, int value)
        {
            Suit = suits[sIdx];
            Value = value;
        }
        public string DisplayValue 
        {
            get 
            { 
                switch(value)
                {
                    case 13:
                        return "King";
                    case 12:
                        return "Queen";
                    case 11:
                        return "Jack";
                    case 1:
                        return "Ace";
                    default:
                        return value.ToString();
                }
            } 
        }
    }
}
