using System.Collections.Generic;
using System.Linq;
using Solo.Interfaces;
using Solo.Models.Cards;
using Solo.Wrappers;

namespace Solo.Models
{
    public class DummyDeck : IDeck
    {
        private readonly IRandom _random;
        private readonly CardList _currentDeck;
        private CardList _drawDeck;

        public DummyDeck() : this(new RandomWrapper()) { }

        private DummyDeck(IRandom random) : this(random, new CardList(new List<ICard>
        {
            new WhiteCard(), new RedCard(), new GreenCard(), new BlueCard(),
            new WhiteCard(), new RedCard(), new GreenCard(), new BlueCard(),
            new WhiteCard(), new RedCard(), new GreenCard(), new BlueCard(),
            new WhiteCard(), new RedCard(), new GreenCard(), new BlueCard()
        }))
        {
        }

        public DummyDeck(IRandom random, CardList currentDeck)
        {
            _random = random;
            _currentDeck = currentDeck;
            _drawDeck = currentDeck;
        }

        public int CardCount() => _currentDeck.Count();

        public override bool Equals(object obj) => obj is DummyDeck deck && Equals(deck);

        private bool Equals(DummyDeck other) => other._currentDeck.Equals(_currentDeck);

        public override int GetHashCode() => (_currentDeck != null ? _currentDeck.GetHashCode() : 0);

        public IDeck Shuffle()
        {
            CardList shuffledCards = new CardList();
            shuffledCards.AddRange(Shuffle(_currentDeck, _random));
            return new DummyDeck(_random, new CardList(shuffledCards));
        }

        private IEnumerable<ICard> Shuffle(List<ICard> source, IRandom rng)
        {
            ICard[] elements = source.ToArray();
            for (int i = elements.Length - 1; i > 0; i--)
            {
                int swapIndex = rng.Next(i + 1);
                yield return elements[swapIndex];
                elements[swapIndex] = elements[i];
            }

            yield return elements[0];
        }

        public List<ICard> Draw(int drawNumber)
        {
            List<ICard> drawnCards = _drawDeck.Take(drawNumber).ToList();
            _drawDeck = new CardList(_drawDeck.Skip(drawNumber).ToList());
            return drawnCards;
        }
    }
}