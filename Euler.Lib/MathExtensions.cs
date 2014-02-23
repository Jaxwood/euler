using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Lib
{
    public static class MathExtensions
    {
        public static BigInteger Factorial(this IEnumerable<int> numbers)
        {
            return numbers.Aggregate(BigInteger.One, (acc, c) => BigInteger.Multiply(acc, c));
        }
    }
}
