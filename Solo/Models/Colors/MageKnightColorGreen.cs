using Solo.Interfaces;

namespace Solo.Models.Colors
{
    public class MageKnightColorGreen : MageKnightColor, IColor
    {
        public MageKnightColorGreen() : base("Green")
        {
        }

        public bool Matches(IColor color)
        {
            return color is MageKnightColorGreen;
        }
    }
}