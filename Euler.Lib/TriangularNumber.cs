using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class TriangularNumber
    {
        private PrimeFactorFinder _primeFactorFinder;

        public TriangularNumber(PrimeFactorFinder primeFactorFinder)
        {            
            this._primeFactorFinder = primeFactorFinder;
        }

        public long GetLowestTriangularNumber(long divisor)
        {
            long cnt = Convert.ToInt64(Math.Sqrt(divisor));
            var natural = this.GetNthTriangularNumber(cnt);
            bool found = this.DivisorsForNumber(natural) >= divisor;

            while (!found)
            {
                cnt++;
                natural = this.GetNthTriangularNumber(cnt);
                found = this.DivisorsForNumber(natural) >= divisor;
            }

            return natural;
        }

        public long GetNthTriangularNumber(long n)
        {
            // (n/2) × (n + 1) = number;
            return (n * (n + 1)) / 2;
        }

        public int DivisorsForNumber(long number)
        {
            var factors = this._primeFactorFinder.GetPrimeFactors(number);

            return factors.GroupBy(c => c)
                          .Select(k => k.Count() + 1)
                          .Aggregate(1, (acc, c) => acc *= c);
        }
    }
}
