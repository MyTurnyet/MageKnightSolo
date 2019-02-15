using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solo.Interfaces;
using Solo.Models.Colors;
using Solo.Models.Crystals;

namespace SoloTests.Models
{
    [TestClass]
    public class CrystalTests
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //assign
            IColor red = new MageKnightColorRed();
            Crystal crystal1 = new Crystal(red);
            Crystal crystal2 = new Crystal(red);

            //assert
            crystal1.Should().Be(crystal2);
        }
        
//        [TestMethod, TestCategory("Unit")]
//        public void ShouldNotEquate()
//        {
//            //assign
//            Crystal crystal1 = new Crystal("Red");
//            Crystal crystal2 = new Crystal("Blue");
//
//            //assert
//            crystal1.Should().NotBe(crystal2);
//        }

//        [TestMethod, TestCategory("Unit")]
//        public void ShouldNotEquateRedAndBlueCrystals()
//        {
//            //assign
//            RedCrystal redCrystal = new RedCrystal();
//            BlueCrystal blueCrystal = new BlueCrystal();
//
//            //assert
//            redCrystal.Should().NotBe(blueCrystal);
//        }
    }
}