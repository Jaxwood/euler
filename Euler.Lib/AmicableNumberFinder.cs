using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Euler.Lib
{
    public class AmicableNumberFinder
    {
        private MathUtil _mathUtil;
        public AmicableNumberFinder(MathUtil util)
        {
            this._mathUtil = util;
        }

        public bool IsAmicableNumber(int number)
        {
            var divisorSum = this._mathUtil.GetSumOfDivisors(number);
            
            if (divisorSum == number) return false;

            return number == this._mathUtil.GetSumOfDivisors(divisorSum);
        }
    }
}
