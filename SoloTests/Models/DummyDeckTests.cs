using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solo.Interfaces;
using Solo.Models;

namespace SoloTests.Models
{
    [TestClass]
    public class DummyDeckTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldHave_0_Cards()
        {
            //assign
            IDummyDeck dummyDeck = new DummyDeck();
            //act
            int cardCount = dummyDeck.CardCount();
            //assert
            cardCount.Should().Be(0);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldHave_2_Cards()
        {
            //assign
            string[] startingDeck = {"r","g","b"};
            IDummyDeck dummyDeck = new DummyDeck(startingDeck);
            //act
            int cardCount = dummyDeck.CardCount();
            //assert
            cardCount.Should().Be(3);
        }
        
    }
}