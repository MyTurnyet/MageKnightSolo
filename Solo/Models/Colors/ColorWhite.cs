using Solo.Interfaces;

namespace Solo.Models.Colors
{
    public class ColorWhite : IColor
    {
        public bool Matches(IColor color) => color is ColorWhite;
    }
}