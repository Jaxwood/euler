using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class LowestDividableNumberFinder
    {
        public int GetLowestNumberDividableWith(int[] numberRange)
        {
            bool found = false;
            int number = numberRange.Last() * numberRange[numberRange.Length-2];
            while(!found)
            {
                if (numberRange.All(c => number % c == 0)) break;
                number = number + numberRange.Last();
            }

            return number;
        }
    }
}
