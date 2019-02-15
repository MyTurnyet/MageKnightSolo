using Solo.Interfaces;
using Solo.Models.Colors;

namespace Solo.Models.Crystals
{
    public class BlueCrystal:Crystal, ICrystal
    {
        public BlueCrystal() : base(new MageKnightColorBlue())
        {
        }

        public bool Matches(ICrystal crystal)
        {
            return crystal is BlueCrystal;
        }
    }
}