using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solo.Interfaces;
using Solo.Models.Colors;

namespace SoloTests.Models
{
    [TestClass]
    public class ColorTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldMatch_Blue_Blue()
        {
            //assign
            IColor blueColor2 = new ColorBlue();
            IColor blueColor1 = new ColorBlue();
            //act
            bool matches = blueColor1.Matches(blueColor2);
            //assert
            matches.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldMatch_Green_Green()
        {
            //assign
            IColor blueColor2 = new ColorGreen();
            IColor blueColor1 = new ColorGreen();
            //act
            bool matches = blueColor1.Matches(blueColor2);
            //assert
            matches.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldMatch_Red_Red()
        {
            //assign
            IColor redColor1 = new ColorRed();
            IColor redColor2 = new ColorRed();
            //act
            bool matches = redColor1.Matches(redColor2);
            //assert
            matches.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldMatch_White_White()
        {
            //assign
            IColor color1 = new ColorWhite();
            IColor color2 = new ColorWhite();
            //act
            bool matches = color1.Matches(color2);
            //assert
            matches.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_Blue_Green()
        {
            //assign
            IColor blue = new ColorBlue();
            IColor green = new ColorGreen();
            //act
            bool matches = blue.Matches(green);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_Blue_Red()
        {
            //assign
            IColor redColor = new ColorRed();
            IColor blueColor = new ColorBlue();
            //act
            bool matches = blueColor.Matches(redColor);
            //assert
            matches.Should().BeFalse();
        }
        
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_Blue_White()
        {
            //assign
            IColor white = new ColorWhite();
            IColor blueColor = new ColorBlue();
            //act
            bool matches = blueColor.Matches(white);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_Green_Blue()
        {
            //assign
            IColor blue = new ColorBlue();
            IColor green = new ColorGreen();
            //act
            bool matches = green.Matches(blue);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_Green_Red()
        {
            //assign
            IColor redColor = new ColorRed();
            IColor green = new ColorGreen();
            //act
            bool matches = green.Matches(redColor);
            //assert
            matches.Should().BeFalse();
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_Green_White()
        {
            //assign
            IColor white = new ColorWhite();
            IColor green = new ColorGreen();
            //act
            bool matches = green.Matches(white);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_Red_Blue()
        {
            //assign
            IColor redColor = new ColorRed();
            IColor blueColor = new ColorBlue();
            //act
            bool matches = redColor.Matches(blueColor);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_Red_Green()
        {
            //assign
            IColor redColor = new ColorRed();
            IColor green = new ColorGreen();
            //act
            bool matches = redColor.Matches(green);
            //assert
            matches.Should().BeFalse();
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_Red_White()
        {
            //assign
            IColor redColor = new ColorRed();
            IColor white = new ColorWhite();
            //act
            bool matches = redColor.Matches(white);
            //assert
            matches.Should().BeFalse();
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_White_Blue()
        {
            //assign
            IColor white = new ColorWhite();
            IColor blueColor = new ColorBlue();
            //act
            bool matches = white.Matches(blueColor);
            //assert
            matches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_White_Green()
        {
            //assign
            IColor white = new ColorWhite();
            IColor green = new ColorGreen();
            //act
            bool matches = white.Matches(green);
            //assert
            matches.Should().BeFalse();
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatch_White_Red()
        {
            //assign
            IColor redColor = new ColorRed();
            IColor white = new ColorWhite();
            //act
            bool matches = white.Matches(redColor);
            //assert
            matches.Should().BeFalse();
        }
    }
}