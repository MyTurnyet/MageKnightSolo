using System;

namespace Solo.Interfaces
{
    public interface ICardList : IEquatable<ICardList>
    {
        bool HasCards();
        int Count();
    }
}