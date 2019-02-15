using Solo.Interfaces;

namespace Solo.Models.Colors
{
    public class MageKnightColorBlue : MageKnightColor,IColor
    {

        public MageKnightColorBlue() : base("Blue")
        {
        }
        public bool Matches(IColor color)
        {
            return color is MageKnightColorBlue;
        }
    }
}