using System;
using System.Collections.Generic;
using System.Text;
using Solo.Interfaces;

namespace Solo.Wrappers
{
   public class RandomizerWrapper:IRandomizer
    {
        private readonly Random _random;

        public RandomizerWrapper(int seed = Int32.MaxValue)
        {
            _random = new Random(seed);
        }
        public int Next(int i) => _random.Next();
    }
}
