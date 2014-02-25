using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class AbundantSum
    {
        private MathUtil _mathUtil;

        public AbundantSum(MathUtil mathUtil)
        {
            this._mathUtil = mathUtil;
        }

        public bool IsAbundant(int number)
        {
            return this._mathUtil.GetSumOfDivisors(number) > number;
        }

        public int[] GetSumOfAbundantNumbers(int[] abundantNumbers)
        {
            return (from a in abundantNumbers
                   from b in abundantNumbers
                   select a + b).Distinct().ToArray();
        }

        public int[] GetAbundantNumbers(int top)
        {
            return Enumerable.Range(1, top)
                             .Where(c => this.IsAbundant(c))
                             .ToArray();
        }

        public int GetSumOfIntegersThatIsNotSumOfAbundantNumbers(int top)
        {
            return Enumerable.Range(1, top).Except(this.GetSumOfAbundantNumbers(this.GetAbundantNumbers(top))).Sum();
        }
    }
}
