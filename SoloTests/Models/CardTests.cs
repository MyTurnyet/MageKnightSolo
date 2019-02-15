using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solo.Interfaces;
using Solo.Models.Cards;

namespace SoloTests.Models
{
    [TestClass]
    public class CardTests
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate_BlueCards()
        {
            //assign
            ICard card1 = new BlueCard();
            ICard card2 = new BlueCard();
            //act
            bool matches = card1.Matches(card2);
            //assert
            matches.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate_GreenCards()
        {
            //assign
            ICard card1 = new GreenCard();
            ICard card2 = new GreenCard();
            //act
            bool matches = card1.Matches(card2);
            //assert
            matches.Should().BeTrue();
        }
        
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate_RedCards()
        {
            //assign
            ICard card1 = new RedCard();
            ICard card2 = new RedCard();
            //act
            bool matches = card1.Matches(card2);
            //assert
            matches.Should().BeTrue();
        }
        
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate_WhiteCards()
        {
            //assign
            ICard card1 = new WhiteCard();
            ICard card2 = new WhiteCard();
            //act
            bool matches = card1.Matches(card2);
            //assert
            matches.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_Blue_Green()
        {
            //assign
            ICard blueCard = new BlueCard();
            ICard greenCard = new GreenCard();
            //act
            bool matches = blueCard.Matches(greenCard);
            //assert
            matches.Should().BeFalse();
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_Blue_Red()
        {
            //assign
            ICard blueCard = new BlueCard();
            ICard redCard = new RedCard();
            //act
            bool matches = blueCard.Matches(redCard);
            //assert
            matches.Should().BeFalse();
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_Blue_White()
        {
            //assign
            ICard blueCard = new BlueCard();
            ICard whiteCard = new WhiteCard();
            //act
            bool matches = blueCard.Matches(whiteCard);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_Green_Blue()
        {
            //assign
            ICard blueCard = new BlueCard();
            ICard greenCard = new GreenCard();
            //act
            bool matches = greenCard.Matches(blueCard);
            //assert
            matches.Should().BeFalse();
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_Green_Red()
        {
            //assign
            ICard greenCard = new GreenCard();
            ICard redCard = new RedCard();
            //act
            bool matches = greenCard.Matches(redCard);
            //assert
            matches.Should().BeFalse();
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_Green_White()
        {
            //assign
            ICard blueCard = new GreenCard();
            ICard whiteCard = new WhiteCard();
            //act
            bool matches = blueCard.Matches(whiteCard);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_Red_Blue()
        {
            //assign
            ICard redCard = new RedCard();
            ICard blueCard = new BlueCard();
            //act
            bool matches = redCard.Matches(blueCard);
            //assert
            matches.Should().BeFalse();
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_Red_Green()
        {
            //assign
            ICard greenCard = new GreenCard();
            ICard redCard = new RedCard();
            //act
            bool matches = redCard.Matches(greenCard);
            //assert
            matches.Should().BeFalse();
            
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_Red_White()
        {
            //assign
            ICard redCard = new RedCard();
            ICard whiteCard = new WhiteCard();
            //act
            bool matches = redCard.Matches(whiteCard);
            //assert
            matches.Should().BeFalse();
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_White_Blue()
        {
            //assign
            ICard whiteCard = new WhiteCard();
            ICard blueCard = new BlueCard();
            //act
            bool matches = whiteCard.Matches(blueCard);
            //assert
            matches.Should().BeFalse();
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_White_Green()
        {
            //assign
            ICard greenCard = new GreenCard();
            ICard whiteCard = new WhiteCard();
            //act
            bool matches = whiteCard.Matches(greenCard);
            //assert
            matches.Should().BeFalse();
            
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_White_Red()
        {
            //assign
            ICard redCard = new RedCard();
            ICard whiteCard = new WhiteCard();
            //act
            bool matches = whiteCard.Matches(redCard);
            //assert
            matches.Should().BeFalse();
        }
    }
}