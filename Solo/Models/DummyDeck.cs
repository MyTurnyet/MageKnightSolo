using System;
using System.Collections.Generic;
using System.Linq;
using Solo.Interfaces;
using Solo.Models.Cards;

namespace Solo.Models
{
    public class DummyDeck : IDeck
    {
        private readonly CardList _currentDeck;
        private CardList _drawDeck;

        public DummyDeck() : this(new CardList(new List<ICard>
        {
            new WhiteCard(), new RedCard(), new GreenCard(), new BlueCard(),
            new WhiteCard(), new RedCard(), new GreenCard(), new BlueCard(),
            new WhiteCard(), new RedCard(), new GreenCard(), new BlueCard(),
            new WhiteCard(), new RedCard(), new GreenCard(), new BlueCard()
        }))
        {
        }

        public DummyDeck(CardList currentDeck)
        {
            _currentDeck = currentDeck;
            _drawDeck = currentDeck;
        }

        public int CardCount() => _currentDeck.Count();

        public override bool Equals(object obj) => obj is DummyDeck deck && Equals(deck);

        private bool Equals(DummyDeck other)
        {
            bool sequenceEqual = _currentDeck.SequenceEqual(other._currentDeck);
            return sequenceEqual;
        }

        public override int GetHashCode() => (_currentDeck != null ? _currentDeck.GetHashCode() : 0);

        public IDeck Shuffle()
        {
            Random random = new Random();
            List<ICard> shuffledCards = _currentDeck.OrderBy(card => random.Next()).ToList();
            return new DummyDeck(new CardList(shuffledCards));
        }

        public List<ICard> Draw(int drawNumber)
        {
            List<ICard> drawnCards = _drawDeck.Take(drawNumber).ToList();
            _drawDeck = new CardList( _drawDeck.Skip(drawNumber).ToList());
            return drawnCards;
        }
    }
}