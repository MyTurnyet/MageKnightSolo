using System.Collections.Generic;
using System.Linq;
using Solo.Interfaces;

namespace Solo.Models.Player
{
    public class DummyPlayer : IDummyPlayer
    {
        private readonly IDeck _startingDummyDeck;
        private readonly IEnumerable<ICrystal> _crystals;

        public DummyPlayer(IDeck startingDummyDeck) : this(startingDummyDeck, new List<ICrystal>()){}

        public DummyPlayer(IDeck startingDummyDeck, IEnumerable<ICrystal> startingCrystals)
        {
            _startingDummyDeck = startingDummyDeck;
            _crystals = startingCrystals;
        }

        public int CardCount() => _startingDummyDeck.CardCount();

        public int CrystalCount() => _crystals.Count();
    }
}