using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class FactorialSumFinder
    {
        public int GetFactorialSum(int factorial)
        {
            return Enumerable.Range(1, factorial)
                             .Factorial()
                             .ToString()
                             .Select(c => (int)Char.GetNumericValue(c))
                             .Sum();
        }
    }
}
