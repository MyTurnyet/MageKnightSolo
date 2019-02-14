using Solo.Interfaces;

namespace Solo.Models
{
    public class DummyDeck : IDummyDeck
    {
        private readonly string[] _startingDeck;

        public DummyDeck(): this(new string[]{}){}

        public DummyDeck(string[] startingDeck)
        {
            _startingDeck = startingDeck;
        }

        public int CardCount()
        {
            return _startingDeck.Length;
        }
    }
}