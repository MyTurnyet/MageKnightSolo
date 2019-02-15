using System.Runtime.InteropServices;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solo.Interfaces;
using Solo.Models.Colors;

namespace SoloTests.Models
{
    [TestClass]
    public class MageKnightColorTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldMatch_Blue_Blue()
        {
            //assign
            IColor blueColor2 = new MageKnightColorBlue();
            IColor blueColor1 = new MageKnightColorBlue();
            //act
            bool matches = blueColor1.Matches(blueColor2);
            //assert
            matches.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldMatch_Green_Green()
        {
            //assign
            IColor blueColor2 = new MageKnightColorGreen();
            IColor blueColor1 = new MageKnightColorGreen();
            //act
            bool matches = blueColor1.Matches(blueColor2);
            //assert
            matches.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldMatch_Red_Red()
        {
            //assign
            IColor redColor1 = new MageKnightColorRed();
            IColor redColor2 = new MageKnightColorRed();
            //act
            bool matches = redColor1.Matches(redColor2);
            //assert
            matches.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldMatch_White_White()
        {
            //assign
            IColor color1 = new MageKnightColorWhite();
            IColor color2 = new MageKnightColorWhite();
            //act
            bool matches = color1.Matches(color2);
            //assert
            matches.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_Blue_Green()
        {
            //assign
            IColor blue = new MageKnightColorBlue();
            IColor green = new MageKnightColorGreen();
            //act
            bool matches = blue.Matches(green);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_Blue_Red()
        {
            //assign
            IColor redColor = new MageKnightColorRed();
            IColor blueColor = new MageKnightColorBlue();
            //act
            bool matches = blueColor.Matches(redColor);
            //assert
            matches.Should().BeFalse();
        }
        
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_Blue_White()
        {
            //assign
            IColor white = new MageKnightColorWhite();
            IColor blueColor = new MageKnightColorBlue();
            //act
            bool matches = blueColor.Matches(white);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_Green_Blue()
        {
            //assign
            IColor blue = new MageKnightColorBlue();
            IColor green = new MageKnightColorGreen();
            //act
            bool matches = green.Matches(blue);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_Green_Red()
        {
            //assign
            IColor redColor = new MageKnightColorRed();
            IColor green = new MageKnightColorGreen();
            //act
            bool matches = green.Matches(redColor);
            //assert
            matches.Should().BeFalse();
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_Green_White()
        {
            //assign
            IColor white = new MageKnightColorWhite();
            IColor green = new MageKnightColorGreen();
            //act
            bool matches = green.Matches(white);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_Red_Blue()
        {
            //assign
            IColor redColor = new MageKnightColorRed();
            IColor blueColor = new MageKnightColorBlue();
            //act
            bool matches = redColor.Matches(blueColor);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_Red_Green()
        {
            //assign
            IColor redColor = new MageKnightColorRed();
            IColor green = new MageKnightColorGreen();
            //act
            bool matches = redColor.Matches(green);
            //assert
            matches.Should().BeFalse();
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_Red_White()
        {
            //assign
            IColor redColor = new MageKnightColorRed();
            IColor white = new MageKnightColorWhite();
            //act
            bool matches = redColor.Matches(white);
            //assert
            matches.Should().BeFalse();
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_White_Blue()
        {
            //assign
            IColor white = new MageKnightColorWhite();
            IColor blueColor = new MageKnightColorBlue();
            //act
            bool matches = white.Matches(blueColor);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_White_Green()
        {
            //assign
            IColor white = new MageKnightColorWhite();
            IColor green = new MageKnightColorGreen();
            //act
            bool matches = white.Matches(green);
            //assert
            matches.Should().BeFalse();
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_White_Red()
        {
            //assign
            IColor redColor = new MageKnightColorRed();
            IColor white = new MageKnightColorWhite();
            //act
            bool matches = white.Matches(redColor);
            //assert
            matches.Should().BeFalse();
        }
    }
}