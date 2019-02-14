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
            IDeck deck = new DummyDeck();
            //act
            int cardCount = deck.CardCount();
            //assert
            cardCount.Should().Be(0);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldHave_2_Cards()
        {
            //assign
            string[] startingDeck = {"r","g","b"};
            IDeck deck = new DummyDeck(startingDeck);
            //act
            int cardCount = deck.CardCount();
            //assert
            cardCount.Should().Be(3);
        }
        
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //assign
            string[] startingDeck = {"r","r","r","r","g","g","g","g","b","b","b","b","w","w","w","w"};
            DummyDeck deck1 = new DummyDeck(startingDeck);
            DummyDeck deck2 = new DummyDeck(startingDeck);
            //assert
            deck1.Should().Be(deck2);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate()
        {
            //assign
            string[] startingDeck = {"r","r","r","r","g","g","g","g","b","b","b","b","w","w","w","w"};
            string[] otherDeck = {"b","r","r","r","g","g","g","g","r","b","b","b","w","w","w","w"};
            DummyDeck deck1 = new DummyDeck(startingDeck);
            DummyDeck deck2 = new DummyDeck(otherDeck);
            //assert
            deck1.Should().NotBe(deck2);
        }
    }
}