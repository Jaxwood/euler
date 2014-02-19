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
            bool found = this._primeFactorFinder.DivisorsForNumber(natural) >= divisor;

            while (!found)
            {
                cnt++;
                natural = this.GetNthTriangularNumber(cnt);
                found = this._primeFactorFinder.DivisorsForNumber(natural) >= divisor;
            }

            return natural;
        }

        public long GetNthTriangularNumber(long n)
        {
            return (n * (n + 1)) / 2;
        }        
    }
}
