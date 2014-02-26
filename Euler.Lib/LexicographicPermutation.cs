using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class LexicographicPermutation
    {
        private MathUtil _mathUtil;

        public LexicographicPermutation(MathUtil mathUtil)
        {
            this._mathUtil = mathUtil;
        }
        public long GetPermutation(int number, int permutation)
        {
            var digits = this._mathUtil.GetDigits(number)
                                       .OrderByDescending(c => c == 0)
                                       .ThenBy(c => c).ToArray();
            var k = -1;
            permutation = permutation - 1;

            while(permutation > 0)
            {
                bool found = false; 
                for (int i = 0; i < digits.Length; i++)
                {
                    // Find the largest index k such that a[k] < a[k + 1]. 
                    // If no such index exists, the permutation is the last permutation.
                    if (i+1 < digits.Length && digits[i] < digits[i + 1])
                    {
                        if (i > k)
                        {
                            k = i;
                            found = true;
                        }
                    }       
                }

                if (!found) break;
                
                // k = Array.IndexOf(digits, k);
                
                // Find the largest index l such that a[k] < a[l].
                var aK = digits[k];
                var aL = digits.Where(c => aK < c).Last();
                var l = Array.IndexOf(digits, aL);

                // Swap the value of a[k] with that of a[l].
                var tmp = digits[k];
                digits[k] = digits[l];
                digits[l] = tmp;                                

                // Reverse the sequence from a[k + 1] up to and including the final element a[n].
                if ( k +1 < digits.Length)
                { 
                    Array.Reverse(digits, k + 1, digits.Length - Array.IndexOf(digits, digits[k + 1]));
                }

                k = -1;
                permutation--;
            }

            return digits.Reverse().Select((c, i) => (long)Math.Pow(10, i)*c).Sum();
        }
    }
}
