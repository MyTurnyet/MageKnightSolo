using Solo.Interfaces;
using Solo.Models.Colors;

namespace Solo.Models.Crystals
{
    public class WhiteCrystal:Crystal, ICrystal
    {
        public WhiteCrystal() : base(new ColorWhite())
        {
        }

        public bool Matches(ICrystal crystal)
        {
            return crystal is WhiteCrystal;
        }
    }
}