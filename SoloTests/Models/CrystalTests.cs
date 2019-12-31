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
            IColor red = new ColorRed();
            Crystal crystal1 = new Crystal(red);
            Crystal crystal2 = new Crystal(red);

            //assert
            crystal1.Should().Be(crystal2);
        }


        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate_BlueCrystals()
        {
            //assign
            ICrystal crystal1 = new BlueCrystal();
            ICrystal crystal2 = new BlueCrystal();

            //act 
            bool matches = crystal1.Matches(crystal2);
            //assert
            matches.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate_GreenCrystals()
        {
            //assign
            ICrystal crystal1 = new GreenCrystal();
            ICrystal crystal2 = new GreenCrystal();

            //act 
            bool matches = crystal1.Matches(crystal2);
            //assert
            matches.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate_RedCrystals()
        {
            //assign
            ICrystal crystal1 = new RedCrystal();
            ICrystal crystal2 = new RedCrystal();

            //act 
            bool matches = crystal1.Matches(crystal2);
            //assert
            matches.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate_WhiteCrystals()
        {
            //assign
            ICrystal crystal1 = new WhiteCrystal();
            ICrystal crystal2 = new WhiteCrystal();

            //act 
            bool matches = crystal1.Matches(crystal2);
            //assert
            matches.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_Blue_Green()
        {
            //assign
            ICrystal blueCrystal = new BlueCrystal();
            ICrystal greenCrystal = new GreenCrystal();

            //act 
            bool matches = blueCrystal.Matches(greenCrystal);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_Blue_Red()
        {
            //assign
            ICrystal blueCrystal = new BlueCrystal();
            ICrystal redCrystal = new RedCrystal();

            //act 
            bool matches = blueCrystal.Matches(redCrystal);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_Blue_White()
        {
            //assign
            ICrystal blueCrystal = new BlueCrystal();
            ICrystal whiteCrystal = new WhiteCrystal();

            //act 
            bool matches = blueCrystal.Matches(whiteCrystal);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_Green_Blue()
        {
            //assign
            ICrystal blueCrystal = new BlueCrystal();
            ICrystal greenCrystal = new GreenCrystal();

            //act 
            bool matches = greenCrystal.Matches(blueCrystal);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_Green_Red()
        {
            //assign
            ICrystal redCrystal = new RedCrystal();
            ICrystal greenCrystal = new GreenCrystal();

            //act 
            bool matches = greenCrystal.Matches(redCrystal);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_Green_White()
        {
            //assign
            ICrystal whiteCrystal = new WhiteCrystal();
            ICrystal greenCrystal = new GreenCrystal();

            //act 
            bool matches = greenCrystal.Matches(whiteCrystal);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_Red_Blue()
        {
            //assign
            ICrystal blueCrystal = new BlueCrystal();
            ICrystal redCrystal = new RedCrystal();

            //act 
            bool matches = redCrystal.Matches(blueCrystal);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_Red_Green()
        {
            //assign
            ICrystal redCrystal = new RedCrystal();
            ICrystal greenCrystal = new GreenCrystal();

            //act 
            bool matches = redCrystal.Matches(greenCrystal);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_Red_White()
        {
            //assign
            ICrystal whiteCrystal = new WhiteCrystal();
            ICrystal redCrystal = new RedCrystal();

            //act 
            bool matches = redCrystal.Matches(whiteCrystal);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_White_Blue()
        {
            //assign
            ICrystal blueCrystal = new BlueCrystal();
            ICrystal whiteCrystal = new WhiteCrystal();

            //act 
            bool matches = whiteCrystal.Matches(blueCrystal);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_White_Green()
        {
            //assign
            ICrystal whiteCrystal = new WhiteCrystal();
            ICrystal greenCrystal = new GreenCrystal();

            //act 
            bool matches = whiteCrystal.Matches(greenCrystal);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate_White_Red()
        {
            //assign
            ICrystal whiteCrystal = new WhiteCrystal();
            ICrystal redCrystal = new RedCrystal();

            //act 
            bool matches = whiteCrystal.Matches(redCrystal);
            //assert
            matches.Should().BeFalse();
        }
    }
}