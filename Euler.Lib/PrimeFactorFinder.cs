using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class PrimeFactorFinder
    {
        private long _number;

        public PrimeFactorFinder(long number)
        {
            this._number = number;
        }

        public long[] GetPrimeFactors()
        {
            return GetPrimes(new long[] {}, 2);
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

            while (!IsPrime(prime))
            {
                prime = prime + 1;
                if (prime == this._number) return this._number;
            }

            return prime;
        }

        private bool IsPrime(long number) 
        {
            if (number <= 3) return true;

            return (number % 2 != 0 && number % 3 != 0);
        }
    }
}
