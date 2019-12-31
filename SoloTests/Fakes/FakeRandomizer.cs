using Solo.Interfaces;

namespace SoloTests.Fakes
{
    public class FakeRandomizer: IRandomizer
    {
        private int nextNumber = 0;
        public int Next(int i)
        {
            return nextNumber;
        }
    }
}