using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solo.Interfaces;
using Solo.Models.Player;

namespace SoloTests.Models.Player
{
    [TestClass]
    public class DummyPlayerTests    
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldHaveStartingDeck_Of2()
        {
            //assign
            string[] startingDeck = {"r","g"};
            IDummyPlayer dummyPlayer = new DummyPlayer(startingDeck);
            //act
            int startingCardCount = dummyPlayer.CardCount();
            //assert
            startingCardCount.Should().Be(2);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldHaveStartingDeck_Of3()
        {
            //assign
            string[] startingDeck = {"r","g","b"};
            IDummyPlayer dummyPlayer = new DummyPlayer(startingDeck);
            //act
            int startingCardCount = dummyPlayer.CardCount();
            //assert
            startingCardCount.Should().Be(3);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldHave_1_StartingCrystal()
        {
            //assign
            string[] startingCrystals = {"g"};
            string[] startingDeck = {"r"};
            IDummyPlayer dummyPlayer = new DummyPlayer(startingDeck, startingCrystals);
            //act
            int startingCrystalCount = dummyPlayer.CrystalCount();
            //assert
            startingCrystalCount.Should().Be(1);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldHave_3_StartingCrystals()
        {
            //assign
            string[] startingCrystals = {"g","b","r"};
            string[] startingDeck = {"r","b","g"};
            IDummyPlayer dummyPlayer = new DummyPlayer(startingDeck, startingCrystals);
            //act
            int startingCrystalCount = dummyPlayer.CrystalCount();
            //assert
            startingCrystalCount.Should().Be(3);
        }
    }
}