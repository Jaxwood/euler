using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class SumOfSquaresCalculator
    {
        public long GetSum(int[] range)
        {
            return Convert.ToInt64(Math.Pow(range.Sum(), 2)) - Convert.ToInt64(range.Select(r => Math.Pow(r, 2)).Sum());
        }
    }
}
