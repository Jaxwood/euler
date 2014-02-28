using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class QuadraticPrime
    {
        private PrimeUtil _primeUtil;

        public QuadraticPrime(PrimeUtil primeUtil)
        {
            this._primeUtil = primeUtil;
        }    

        public long GetProduct(int aLow, int aCount, int bLow, int bCount)
        {
            var rangeA = Enumerable.Range(aLow, aCount).ToArray();
            var rangeB = Enumerable.Range(bLow, bCount).ToArray();
            var product = 0;
            var streak = 0;
            
            for (int i = 0; i < rangeA.Length; i++)
            {                
                for (int j = 0; j < rangeB.Length; j++)
                {
                    var count = GetPrimes(rangeA[i], rangeB[j]);

                    if (count > streak)
                    {
                        streak = count;
                        product = rangeA[i] * rangeB[j];
                    }
                }
            }

            return product;
        }

        public int GetPrimes(int a, int b)
        {
            bool isPrime = true;
            var count = 0;
            
            while (isPrime)
            {
                isPrime = this._primeUtil.IsPrime(Convert.ToInt64(form(count, a, b)));
                if ( isPrime ) ++count;
            }
            
            return count;
        }

        private Func<int, int, int, double> form = (n, a, b) => Math.Pow(n,2) + (n*a) + b;
    }
}
