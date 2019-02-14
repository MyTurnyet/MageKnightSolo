using Solo.Interfaces;

namespace Solo.Models.Player
{
    public class DummyPlayer : IDummyPlayer
    {
        private readonly string[] _startingCrystals;
        private readonly string[] _startingDeck;

        public DummyPlayer(string[] startingDeck):this(startingDeck, new string[]{}){}

        public DummyPlayer(string[] startingDeck, string[] startingCrystals)
        {
            _startingDeck = startingDeck;
            _startingCrystals = startingCrystals;
        }

        public int CardCount()
        {
            return _startingDeck.Length;
        }

        public int CrystalCount()
        {
            return _startingCrystals.Length;
        }
    }
}