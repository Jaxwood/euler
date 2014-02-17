using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class PrimeGenerator
    {
        private PrimeUtil _primeUtil;

        public PrimeGenerator(PrimeUtil primeUtil)
        {
            this._primeUtil = primeUtil;
        }
        
        public long[] GetPrimes(int number)
        {
            var result = new List<long>();
            long cnt = 0;

            while(result.Count() != number)
            {
                if ( this._primeUtil.IsPrime(cnt) )
                {
                    result.Add(cnt);
                }
                cnt++;
            }
            
            return result.ToArray();
        }
    }
}
