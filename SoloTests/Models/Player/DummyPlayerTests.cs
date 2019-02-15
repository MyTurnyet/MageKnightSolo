using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solo.Interfaces;
using Solo.Models;
using Solo.Models.Player;

namespace SoloTests.Models.Player
{
    [TestClass]
    public class DummyPlayerTests    
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldHave_1_StartingCrystal()
        {
            //assign
            string[] startingCrystals = {"g"};
            IDeck startingDummyDeck = new DummyDeck();
            IDummyPlayer dummyPlayer = new DummyPlayer(startingDummyDeck, startingCrystals);
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
            IDeck startingDummyDeck = new DummyDeck();

            IDummyPlayer dummyPlayer = new DummyPlayer(startingDummyDeck, startingCrystals);
            //act
            int startingCrystalCount = dummyPlayer.CrystalCount();
            //assert
            startingCrystalCount.Should().Be(3);
        }
    }
}