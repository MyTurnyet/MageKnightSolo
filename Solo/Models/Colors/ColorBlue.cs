using Solo.Interfaces;

namespace Solo.Models.Colors
{
    public class ColorBlue : IColor
    {
        public bool Matches(IColor otherColor) => otherColor is ColorBlue;
    }
}