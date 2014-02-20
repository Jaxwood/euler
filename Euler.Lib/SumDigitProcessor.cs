using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Euler.Lib
{
    public class SumDigitProcessor
    {
        private int digitlength;

        public SumDigitProcessor(int digitlength)
        {
            this.digitlength = digitlength;
        }
        public BigInteger Sum(string digitsequence)
        {
            var seq = this.ConvertToArray(digitsequence);
            var result = BigInteger.Zero;
            
            for(int i = 0; i < seq.Length; i += digitlength)
            {
                result = BigInteger.Add(result, seq.Skip(i).Take(digitlength).Merge());
            }

            return result;
        }

        private int[] ConvertToArray(string series)
        {
            return series.Select(c => (int)Char.GetNumericValue(c)).ToArray();
        }
    }

    internal static class MergeExtension
    {
        public static BigInteger Merge(this IEnumerable<int> digits)
        {
            var val = BigInteger.Zero;
            return digits.Select(c => Convert.ToInt64(c))
                        .Reverse()
                        .Select((c, i) => BigInteger.Multiply(c, BigInteger.Pow(10, i)))
                        .Aggregate(val, (acc, next) => BigInteger.Add(acc, next));
        }
    }
}
