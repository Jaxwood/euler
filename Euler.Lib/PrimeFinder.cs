using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class PrimeFinder
    {
        private PrimeUtil primeUtil;

        public PrimeFinder(PrimeUtil primeUtil)
        {
            this.primeUtil = primeUtil;
        }

        public long GetSumOfPrimes(int max)
        {
            return Enumerable.Range(0, max)
                             .Select(c => Convert.ToInt64(c))
                             .Where(c => primeUtil.IsPrime(c))
                             .Sum();
        }
    }
}
