using Solo.Interfaces;

namespace Solo.Models.Colors
{
    public class ColorGreen : IColor
    {
        public bool Matches(IColor color) => color is ColorGreen;
    }
}