using Solo.Interfaces;

namespace Solo.Models.Cards
{
    public class GreenCard : ICard
    {
        public bool Matches(ICard card)
        {
            return card is GreenCard;
        }
    }
}