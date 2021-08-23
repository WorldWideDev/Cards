using System;
using System.Collections.Generic;
using Xunit;
using CardGame.Models;
using System.Linq;
namespace CardGame.Test
{
    public class CardDeckTests
    {
        [Fact]
        public void DeckIs52()
        {
            // Arrange
            CardDeck deck = new CardDeck();
            // Act
            int expcted = 52;
            int actual = deck.Deck.Count;
            // Assert
            Assert.Equal(actual, expcted);
        }
        [Fact]
        public void DealRemovesCard()
        {
            // Arrange
            CardDeck cardDeck = new CardDeck();
            // Act
            var card = cardDeck.Deal();
            int expcted = 51;
            // Assert
            Assert.IsType<Card>(card);
            Assert.Equal(cardDeck.Deck.Count, expcted);
        }
        [Fact]
        public void DealingEmptyDeckThrowsException()
        {
            // Arrange
            CardDeck cardDeck = new CardDeck();
            // Act
            for(int i=0; i<52; i++)
                cardDeck.Deal();
            // Assert
            var exception = Assert.Throws<KeyNotFoundException>(() => cardDeck.Deal());
            Assert.Equal("Can not deal from empty deck!", exception.Message);
        }
    }

}
