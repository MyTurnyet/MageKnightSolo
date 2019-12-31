using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solo.Interfaces;
using Solo.Models.Cards;

namespace SoloTests.Models
{
    [TestClass]
    public class CardListTests
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotHoldCards()
        {
            //assign
            ICardList list = new CardList();
            //act
            bool hasCards = list.HasCards();
            //assert
            hasCards.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldHaveCards()
        {
            //assign
            List<ICard> cards = new List<ICard> {new BlueCard()};
            ICardList list = new CardList(cards);
            //act
            bool hasCards = list.HasCards();
            //assert
            hasCards.Should().BeTrue();
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldAddCardsToList()
        {
            //assign
            List<ICard> cards = new List<ICard> {new BlueCard()};
            ICardList list = new CardList(cards);
            //act
            int count = list.Count();
            //assert
            count.Should().Be(1);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //assign
            List<ICard> cards = new List<ICard> {new BlueCard()};
            List<ICard> cards2 = new List<ICard> {new BlueCard()};
            ICardList list = new CardList(cards);
            ICardList list2 = new CardList(cards2);
            
            //act
            //assert
            list.Should().Be(list2);

        }
    }
}