using System;
namespace CardGame.Models
{
    public class Card
    {
        public static string[] suits = {"Clubs", "Diamonds", "Hearts", "Spades"};
        private short _value;
        public string Suit {get; private set;}
        public Card(int sIdx, short value)
        {
            Suit = suits[sIdx];
            _value = value;
        }
        public string Value
        {
            get 
            { 
                switch(_value)
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
                        return _value.ToString();
                }
            } 
        }
        public string DisplayValue => $"{Value.ToString()} of {Suit}";
        public char DisplayValueShort => 
            isFaceCard ? DisplayValue[0] : _value == 10 ? 'T' : DisplayValue[0];
        private bool isFaceCard => _value == 1 || _value > 10;
        
    }
}
