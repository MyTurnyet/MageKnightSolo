using Solo.Interfaces;
using Solo.Models.Colors;

namespace Solo.Models.Crystals
{
    public class GreenCrystal:Crystal, ICrystal
    {
        public GreenCrystal() : base(new MageKnightColorGreen())
        {
        }

        public bool Matches(ICrystal crystal)
        {
            return crystal is GreenCrystal;
        }
    }
}