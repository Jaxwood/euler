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

        public bool IsTriangularNumber(long number)
        {            
            // (Sqrt[1+8x] - 1)/2.
            var res = 1 + (8 * number);
            
            if (res % 2 == 0) return false;
            
            return IsPerfectSquare(res);
        }

        public long GetNthTriangularNumber(long n)
        {
            // (n/2) × (n + 1) = number;
            return (n * (n + 1)) / 2;
        }

        private bool IsPerfectSquare(long input)
        {
            double root = Math.Sqrt(input);

            long rootBits = BitConverter.DoubleToInt64Bits(root);
            long lowerBound = (long)BitConverter.Int64BitsToDouble(rootBits - 1);
            long upperBound = (long)BitConverter.Int64BitsToDouble(rootBits + 1);

            for (long candidate = lowerBound; candidate <= upperBound; candidate++)
            {
                if (candidate * candidate == input)
                {
                    return true;
                }
            }

            return false;
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
