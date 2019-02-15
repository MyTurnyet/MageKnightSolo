using System.Collections.Generic;

namespace Solo.Interfaces
{
    public interface IDeck
    {
        int CardCount();
        IDeck Shuffle();
        List<ICard> Draw(int drawNumber);
    }
}