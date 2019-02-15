using Solo.Interfaces;

namespace Solo.Models.Cards
{
    public class WhiteCard : ICard
    {
        public bool Matches(ICard card)
        {
            return card is WhiteCard;
        }
    }
}