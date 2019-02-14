using System;
using System.Collections.Generic;
using System.Linq;
using Solo.Interfaces;

namespace Solo.Models
{
    public class DummyDeck : IDeck
    {
        private readonly string[] _currentDeck;
        private string[]  _drawDeck;

        public DummyDeck() : this(
            new[] {"r", "r", "r", "r", "g", "g", "g", "g", "b", "b", "b", "b", "w", "w", "w", "w"})
        {
        }

        public DummyDeck(string[] currentDeck)
        {
            _currentDeck = currentDeck;
            _drawDeck = currentDeck;
        }

        public int CardCount() => _currentDeck.Length;

        public override bool Equals(object obj) => obj is DummyDeck deck && Equals(deck);
        private bool Equals(DummyDeck other) => _currentDeck.SequenceEqual(other._currentDeck);
        public override int GetHashCode() => (_currentDeck != null ? _currentDeck.GetHashCode() : 0);

        public IDeck Shuffle()
        {
            Random random = new Random();
            return new DummyDeck(_currentDeck.OrderBy(card => random.Next()).ToArray());
        }

        public string[] Draw()
        {
            string[] drawnCards = _drawDeck.Take(3).ToArray();
            _drawDeck = _drawDeck.Skip(3).ToArray();
            return drawnCards;
        }
    }
}