using Solo.Interfaces;

namespace Solo.Models
{
    public class DummyDeck : IDeck
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

//        public IDeck Shuffle()
//        {
//            throw new System.NotImplementedException();
//        }

        public override bool Equals(object obj)
        {
            return obj is DummyDeck && Equals((DummyDeck) obj);
        }

        private bool Equals(DummyDeck other)
        {
            return Equals(_startingDeck, other._startingDeck);
        }

        public override int GetHashCode()
        {
            return (_startingDeck != null ? _startingDeck.GetHashCode() : 0);
        }
    }
}