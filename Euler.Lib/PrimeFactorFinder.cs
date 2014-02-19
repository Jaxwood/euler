using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class PrimeFactorFinder
    {
        private long _number;
        private PrimeUtil _primeUtil;

        public PrimeFactorFinder(PrimeUtil primeUtil)
        {
            this._primeUtil = primeUtil;
        }

        public long[] GetPrimeFactors(long number)
        {
            this._number = number;
            return GetPrimes(new long[] {}, 2);
        }

        public int DivisorsForNumber(long number)
        {
            var factors = this.GetPrimeFactors(number);

            return factors.GroupBy(c => c)
                          .Select(k => k.Count() + 1)
                          .Aggregate(1, (acc, c) => acc *= c);
        }

        private long[] GetPrimes(long[] factors, long prime)
        {
            if (this._number == 1) return factors;

            if (this.IsFactorial(prime))
            {
                Array.Resize(ref factors, factors.Length + 1);
                factors[factors.Length - 1] = prime;
                this._number = this._number / prime;
                return GetPrimes(factors, prime);
            }

            var nextPrime = GetNextPrime(prime);

            return GetPrimes(factors, nextPrime);
        }

        private bool IsFactorial(long number)
        {
            return this._number % number == 0;
        }

        private long GetNextPrime(long prime) 
        {
            prime = prime + 1;

            while (!this._primeUtil.IsPrime(prime) && !IsSameAsNumber(prime))
            {
                prime = prime + 1;
            }

            return prime;
        }

        private bool IsSameAsNumber(long prime)
        {
            return prime == this._number;
        }

        
    }
}
