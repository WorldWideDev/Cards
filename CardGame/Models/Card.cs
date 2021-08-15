namespace CardGame.Models
{
    public class Card
    {
        public static string[] suits = {"Clubs", "Diamonds", "Hearts", "Spades"};
        public string Suit {get; private set;}
        public static short Value {get; private set;}
        public Card(int sIdx, short value)
        {
            Suit = suits[sIdx];
            Value = value;
        }
        public string DisplayValue 
        {
            get 
            { 
                string suitString = $" of {Suit}";
                switch(Value)
                {
                    case 13:
                        return $"King{suitString}";
                    case 12:
                        return $"Queen{suitString}";
                    case 11:
                        return $"Jack{suitString}";
                    case 1:
                        return $"Ace{suitString}";
                    default:
                        return $"{Value.ToString()}{suitString}";
                }
            } 
        }
    }
}
