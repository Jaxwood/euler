using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Euler.Lib
{
    public class AmicableNumberFinder
    {
        public bool IsAmicableNumber(int number)
        {
            var divisorSum = this.GetSumOfDivisors(number);
            
            if (divisorSum == number) return false;

            return number == this.GetSumOfDivisors(divisorSum);
        }

        private int GetSumOfDivisors(int number)
        {
            return (from y in Enumerable.Range(1, (int) number / 2)
                    where number % y == 0
                    select y).Sum();
        }
    }
}
