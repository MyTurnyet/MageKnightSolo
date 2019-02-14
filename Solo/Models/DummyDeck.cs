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
        public int CardCount() => _currentDeck.Length;
        public IDeck Shuffle() => new DummyDeck(_currentDeck.OrderBy(card=> new Random().Next()).ToArray());

        public override bool Equals(object obj) => obj is DummyDeck deck && Equals(deck);
        private bool Equals(DummyDeck other) => _currentDeck.SequenceEqual(other._currentDeck);
        public override int GetHashCode() => (_currentDeck != null ? _currentDeck.GetHashCode() : 0);
    }
}