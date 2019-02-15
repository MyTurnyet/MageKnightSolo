using Solo.Interfaces;

namespace Solo.Models.Colors
{
    public class MageKnightColorWhite : MageKnightColor, IColor
    {
        public MageKnightColorWhite() : base("White")
        {
        }

        public bool Matches(IColor color)
        {
            return color is MageKnightColorWhite;
        }
    }
}