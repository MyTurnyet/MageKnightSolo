using Solo.Interfaces;

namespace Solo.Models.Colors
{
    public class ColorRed:IColor
    {
        public bool Matches(IColor color) => color is ColorRed;
    }
}