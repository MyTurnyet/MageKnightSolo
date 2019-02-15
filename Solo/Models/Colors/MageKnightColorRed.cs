using Solo.Interfaces;

namespace Solo.Models.Colors
{
    public class MageKnightColorRed:MageKnightColor, IColor
    {
        public MageKnightColorRed() : base("Red")
        {
        }

        public bool Matches(IColor color)
        {
            return color is MageKnightColorRed;
        }
    }
}