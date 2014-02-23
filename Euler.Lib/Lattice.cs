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

            var nFac = Enumerable.Range(1, n)                                 
                                 .Factorial();

            var nkFac = Enumerable.Range(1, n - k)                                  
                                  .Factorial();
            
            var kFac = Enumerable.Range(1, k)                                 
                                 .Factorial();

            return BigInteger.Divide(nFac, BigInteger.Multiply(nkFac, kFac));
        }
    }
}
