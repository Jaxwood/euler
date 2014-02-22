using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Euler.Lib
{
    public class Lattice
    {
        // binomical coefficient
        // n! / ((n-k)! k!)

        public BigInteger GetPaths(int a, int b)
        {
            var n = a + b;
            var k = a;

            var nfac = Enumerable.Range(1, n)
                                 .Select(c => Convert.ToInt64(c))
                                 .Aggregate(BigInteger.Parse("1"), (acc, i) => BigInteger.Multiply(acc, i));


            var nkfac = Enumerable.Range(1, n - k)
                                  .Select(c => Convert.ToInt64(c))
                                  .Aggregate(BigInteger.Parse("1"), (acc, i) => BigInteger.Multiply(acc, i));
            
            
            var kfac = Enumerable.Range(1, k)
                                 .Select(c => Convert.ToInt64(c))
                                 .Aggregate(BigInteger.Parse("1"), (acc, i) => BigInteger.Multiply(acc, i));

            return BigInteger.Divide(nfac, BigInteger.Multiply(nkfac, kfac));
        }
    }
}
