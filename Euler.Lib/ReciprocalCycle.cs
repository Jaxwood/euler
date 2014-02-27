using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Euler.Lib
{
    public class ReciprocalCycle
    {
        private PrimeFactorFinder _primeFactorFinder;
        private MathUtil _mathUtil;

        public ReciprocalCycle(PrimeFactorFinder primeFactorFinder)
        {
            this._primeFactorFinder = primeFactorFinder;
            this._mathUtil = new MathUtil();
        }

        public int GetRecurring(long denominator)
        {
            var factors = this._primeFactorFinder.GetPrimeFactors(denominator);

            var m = factors.Where(c => c != 2 && c != 5);

            if (m.Count() == 0) return 0;

            var a = factors.Count(c => c == 2);
            var b = factors.Count(c => c == 5);

            // N = 2^a * 5^b * M
            var n = (long)(Math.Pow(2, a) * Math.Pow(5,b));
            var M = (long)(denominator / n);

            var cnt = 1;
            long number = 99;
            
            if (number % M == 0) return 1;

            while (number % M  != 0)
            {
                number = ((number % M) * 10) + 9;
                cnt = cnt + 1;
            }

            return ++cnt;
        }

        public long GetLargestRecurring(long top)
        {
            long result = 0;
            long tmp = 0;

            for (int i = 2; i < top; i++)
            {
                var rec = this.GetRecurring(i);
                if (rec > tmp)
                {
                    tmp = rec;
                    result = i;
                }
            }

            return result;
        }
    }
}
