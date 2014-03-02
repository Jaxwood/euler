using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Euler.Lib
{
    public class DistinctPower
    {
        public BigInteger[] GetPowers(int low, int high)
        {
            int count = (high - low) + 1;
            return (from a in Enumerable.Range(low, count)
                    from b in Enumerable.Range(low, count)
                    select BigInteger.Pow(a, b))
                    .Distinct()
                    .OrderBy(c => c)                    
                    .ToArray();
        }

        public int GetNumberOfTerms(int low, int high)
        {
            return this.GetPowers(low, high).Count();
        }
    }
}
