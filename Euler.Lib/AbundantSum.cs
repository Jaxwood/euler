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
    }
}
