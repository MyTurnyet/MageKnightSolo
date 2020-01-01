using System;
using Solo.Interfaces;

namespace Solo.Wrappers
{
   public class RandomWrapper:IRandom
    {
        private readonly Random _random;

        public RandomWrapper(int seed = Int32.MaxValue)
        {
            _random = new Random(seed);
        }
        public int Next(int seed = Int32.MaxValue) => _random.Next(seed);
    }
}
