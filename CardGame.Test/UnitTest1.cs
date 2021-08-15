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
            Assert.Equal(card.DisplayValue, expcted);

        }
    }
}
