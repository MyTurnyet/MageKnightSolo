using Solo.Interfaces;
using Solo.Models.Colors;

namespace Solo.Models.Crystals
{
    public class RedCrystal:Crystal, ICrystal
    {
        public RedCrystal() : base(new ColorRed())
        {
        }

        public bool Matches(ICrystal crystal)
        {
            return crystal is RedCrystal;
        }
    }
}