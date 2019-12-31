using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solo.Interfaces;
using Solo.Models;
using Solo.Models.Cards;

namespace SoloTests.Models
{
    [TestClass]
    public class DummyDeckTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //assign
            List<ICard> startingDeck = new List<ICard>
            {
                new RedCard(), new GreenCard(), new BlueCard(),
                new RedCard(), new GreenCard(), new BlueCard(),
                new RedCard(), new GreenCard(), new BlueCard()
            };
            List<ICard> startingDeck2 = new List<ICard>
            {
                new RedCard(), new GreenCard(), new BlueCard(),
                new RedCard(), new GreenCard(), new BlueCard(),
                new RedCard(), new GreenCard(), new BlueCard()
            };
            CardList cardList = new CardList(startingDeck);
            CardList cardList2 = new CardList(startingDeck2);
            DummyDeck deck1 = new DummyDeck(cardList);
            DummyDeck deck2 = new DummyDeck(cardList2);
            //assert
            deck1.Should().Be(deck2);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate()
        {
            //assign
            List<ICard> startingDeck1 = new List<ICard>
            {
                new RedCard(), new GreenCard(), new BlueCard(),
                new RedCard(), new GreenCard(), new BlueCard(),
                new RedCard(), new GreenCard(), new BlueCard()
            };

            List<ICard> startingDeck2 = new List<ICard>
            {
                new RedCard(), new GreenCard(), new BlueCard(),
                new RedCard(), new GreenCard(), new BlueCard(),
                new GreenCard(),new RedCard(), new BlueCard()
            };

            CardList cardList1 = new CardList(startingDeck1);
            CardList cardList2 = new CardList(startingDeck2);
            DummyDeck deck1 = new DummyDeck(cardList1);
            DummyDeck deck2 = new DummyDeck(cardList2);
            //assert
            deck1.Should().NotBe(deck2);
        }


        [TestMethod, TestCategory("Unit")]
        public void ShouldDraw_3Cards()
        {
            //assign
            List<ICard> startingDeck = new List<ICard>
            {
                new RedCard(), new GreenCard(), new BlueCard(),
                new RedCard(), new BlueCard(), new RedCard(), new GreenCard()
            };
            List<ICard> expectedReturn = new List<ICard>
            {
                new RedCard(), new GreenCard(), new BlueCard(),
            };

            CardList cardList = new CardList(startingDeck);
            IDeck currentDeck = new DummyDeck(cardList);
            //act
            List<ICard> drawnCards = currentDeck.Draw(3);
            //assert
            expectedReturn.ForEach(card => drawnCards.Should().ContainSingle(actualCard => actualCard.Matches(card)));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldDraw_DifferentCards_WhenCalledAgain()
        {
            //assign
            List<ICard> startingDeck = new List<ICard>
            {
                new RedCard(), new GreenCard(), new BlueCard(),
                new RedCard(), new BlueCard(), new RedCard(), new GreenCard()
            };
            List<ICard> firstExpected = new List<ICard>
            {
                new RedCard(), new GreenCard(), new BlueCard(),
            };
            List<ICard> secondExpected = new List<ICard>
            {
                new RedCard(), new BlueCard(),
            };

            CardList cardList = new CardList(startingDeck);
            IDeck currentDeck = new DummyDeck(cardList);
            //act
            List<ICard> firstDraw = currentDeck.Draw(3);
            List<ICard> secondDraw = currentDeck.Draw(2);

            //assert
            firstExpected.ForEach(card => firstDraw.Should().ContainSingle(actualCard => actualCard.Matches(card)));
            secondExpected.ForEach(card => secondDraw.Should().ContainSingle(actualCard => actualCard.Matches(card)));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldDraw_Cards_WhenLessThanRequestedAmountExists()
        {
            //assign
            List<ICard> startingDeck = new List<ICard>
            {
                new RedCard(), new GreenCard()
            };
            List<ICard> expectedReturn = new List<ICard>
            {
                new RedCard(), new GreenCard()
            };

            CardList cardList = new CardList(startingDeck);
            IDeck currentDeck = new DummyDeck(cardList);
            //act
            List<ICard> drawnCards = currentDeck.Draw(5);
            //assert
            expectedReturn.ForEach(card => drawnCards.Should().ContainSingle(actualCard => actualCard.Matches(card)));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldShuffleCards()
        {
            //assign
            List<ICard> startingDeck = new List<ICard>
            {
                new RedCard(), new GreenCard(), new BlueCard(),
                new RedCard(), new BlueCard(), new RedCard(), new GreenCard()
            };
            CardList cardList = new CardList(startingDeck);
            IDeck currentDeck = new DummyDeck(cardList);
            //act
            List<ICard> firstDrawCards = currentDeck.Draw(7);

            //assert
            firstDrawCards.Should().ContainInOrder(startingDeck);

            IDeck shuffledDeck = currentDeck.Shuffle();
            shuffledDeck.Should().NotBe(startingDeck);
        }
    }
}