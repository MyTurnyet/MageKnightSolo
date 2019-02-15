using Solo.Interfaces;

namespace Solo.Models.Cards
{
    public class RedCard : ICard
    {
        public bool Matches(ICard card)
        {
            return card is RedCard;
        }
    }
}