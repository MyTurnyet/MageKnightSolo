using System;
using System.Linq;
using Solo.Interfaces;

namespace Solo.Models
{
    public class DummyDeck : IDeck
    {
        private readonly string[] _currentDeck;

        public DummyDeck(): this(new []{"r","r","r","r","g","g","g","g","b","b","b","b","w","w","w","w"}){}

        public DummyDeck(string[] currentDeck)
        {
            _currentDeck = currentDeck;
        }

        public int CardCount()
        {
            return _currentDeck.Length;
        }

        public IDeck Shuffle()
        {
            Random rnd = new Random();
            return new DummyDeck(_currentDeck.OrderBy(card=> rnd.Next()).ToArray());
        }


        public override bool Equals(object obj)
        {
            return obj is DummyDeck deck && Equals(deck);
        }

        private bool Equals(DummyDeck other)
        {
            return _currentDeck.SequenceEqual(other._currentDeck);
        }

        public override int GetHashCode()
        {
            return (_currentDeck != null ? _currentDeck.GetHashCode() : 0);
        }
    }
}