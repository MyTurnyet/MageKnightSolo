using System.Collections.Generic;
using System.Linq;
using Solo.Interfaces;

namespace Solo.Models.Cards
{
    public class CardList : List<ICard>, ICardList
    {
        public CardList() : this(new List<ICard>()) { }

        public CardList(List<ICard> cards) : base(cards) { }

        public override bool Equals(object obj) => obj is CardList list && Equals(list);

        private bool Equals(CardList other)
        {
            if (other.Count() != Count()) return false;
            for (int i = 0; i < Count(); i++)
            {
                if (other[i].Matches(this[i])) continue;
                return false;
            }
            return true;
        }

        public bool HasCards() => this.Any();

        public new int Count() => base.Count;
    }
}