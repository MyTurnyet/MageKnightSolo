using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solo.Interfaces;
using Solo.Models;
using Solo.Models.Crystals;
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
            IEnumerable<ICrystal> crystals = new List<ICrystal> {new GreenCrystal()};
            IDeck startingDummyDeck = new DummyDeck();
            IDummyPlayer dummyPlayer = new DummyPlayer(startingDummyDeck, crystals);
            //act
            int startingCrystalCount = dummyPlayer.CrystalCount();
            //assert
            startingCrystalCount.Should().Be(1);
        }
        
        [TestMethod, TestCategory("Unit")]
        public void ShouldHave_0_StartingCrystals()
        {
            //assign
            IDeck startingDummyDeck = new DummyDeck();
            IDummyPlayer dummyPlayer = new DummyPlayer(startingDummyDeck);
            //act
            int startingCrystalCount = dummyPlayer.CrystalCount();
            //assert
            startingCrystalCount.Should().Be(0);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldHave_3_StartingCrystals()
        {
            //assign
            IEnumerable<ICrystal> crystals = new List<ICrystal> {new GreenCrystal(),new BlueCrystal(), new RedCrystal()};
            IDeck startingDummyDeck = new DummyDeck();
            IDummyPlayer dummyPlayer = new DummyPlayer(startingDummyDeck, crystals);

            //act
            int startingCrystalCount = dummyPlayer.CrystalCount();
            //assert
            startingCrystalCount.Should().Be(3);
        }
    }
}