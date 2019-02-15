using System.Collections.Generic;
using System.Linq;
using Solo.Interfaces;

namespace Solo.Models.Cards
{
    public class CardList: List<ICard>, ICardList
    {
        public CardList():this(new List<ICard>()){}

        public CardList(List<ICard> cards) : base(cards)
        {
        }


        public bool HasCards()
        {
            return this.Any();
        }

        public new int Count()
        {
            return base.Count;
        }
    }
}