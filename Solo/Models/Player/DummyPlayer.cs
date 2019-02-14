using Solo.Interfaces;

namespace Solo.Models.Player
{
    public class DummyPlayer : IDummyPlayer
    {
        private readonly IDeck _startingDummyDeck;
        private readonly string[] _startingCrystals;

        public DummyPlayer(IDeck startingDummyDeck):this(startingDummyDeck, new string[]{}){}

        public DummyPlayer(IDeck startingDummyDeck, string[] startingCrystals)
        {
            _startingDummyDeck = startingDummyDeck;
            _startingCrystals = startingCrystals;
        }

        public int CardCount()
        {
            return _startingDummyDeck.CardCount();
        }

        public int CrystalCount()
        {
            return _startingCrystals.Length;
        }
    }
}