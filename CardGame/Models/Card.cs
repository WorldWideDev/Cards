using System;
namespace CardGame.Models
{
    public class Card
    {
        public static string[] suits = {"Clubs", "Diamonds", "Hearts", "Spades"};
        public string Suit {get; private set;}
        public short Value {get; private set;}
        public Card(int sIdx, short value)
        {
            Suit = suits[sIdx];
            Value = value;
        }
        private bool isFaceCard => Value == 1 || Value > 10;
        public char DisplayValueShort => 
            isFaceCard ? DisplayValue[0] : Value == 10 ? 'T' : DisplayValue[0];
        
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
