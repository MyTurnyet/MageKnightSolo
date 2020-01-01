using Solo.Interfaces;

namespace SoloTests.Fakes
{
    public class FakeRandom: IRandom
    {
        private int nextNumber = 0;
        public int Next(int i)
        {
            return nextNumber;
        }
    }
}