using System;
using Xunit;
using CardGame.Models;

namespace CardGame.Test
{
    public class CardTests
    {
        [Fact]
        public void OneIsAce()
        {
            // Arrange
            Card card = new Card(0,1);
            // Act

            string expcted = "Ace";
            // Assert
            Assert.Equal(card.Value, expcted);
        }
        [Fact] void TenIsT()
        {
            // Arrange
            Card card = new Card(0,10);
            // Act

            string expcted = "T";
            string actual = card.DisplayValueShort.ToString();
            // Assert
            Assert.Equal(actual, expcted);
        }
        [Fact] void ClubIs0()
        {
            // Arrange
            Card card = new Card(0,10);
            // Act
            string expcted = "Clubs";
            string actual = card.Suit;
            // Assert
            Assert.Equal(actual, expcted);
        }
        [Fact] void DiamondsIs1()
        {
            // Arrange
            Card card = new Card(1,10);
            // Act
            string expcted = "Diamonds";
            string actual = card.Suit;
            // Assert
            Assert.Equal(actual, expcted);
        }
        [Fact] void HeartsIs2()
        {
            // Arrange
            Card card = new Card(2,10);
            // Act
            string expcted = "Hearts";
            string actual = card.Suit;
            // Assert
            Assert.Equal(actual, expcted);
        }
        [Fact] void SpadesIs3()
        {
            // Arrange
            Card card = new Card(3,10);
            // Act
            string expcted = "Spades";
            string actual = card.Suit;
            // Assert
            Assert.Equal(actual, expcted);
        }
    }
}
