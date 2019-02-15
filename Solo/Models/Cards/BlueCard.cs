using Solo.Interfaces;

namespace Solo.Models.Cards
{
    public class BlueCard : ICard
    {
        public bool Matches(ICard card)
        {
            return card is BlueCard;
        }
    }
}