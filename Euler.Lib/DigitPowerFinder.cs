using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class DigitPowerFinder
    {
        private MathUtil _mathUtil;

        public DigitPowerFinder(MathUtil mathUtil)
        {
            this._mathUtil = mathUtil;
        }

        public int[] GetNumbersWithPower(int power)
        {
            var upper = this.GetUpperLimit(power);
            return (from d in Enumerable.Range(2, upper)
                    let sum = this._mathUtil.GetDigits(d).Select(e => (int)Math.Pow(e, power)).Sum()
                    where d == sum
                    select d).ToArray();
        }

        public int GetSum(int power)
        {
            return this.GetNumbersWithPower(power).Sum();
        }

        private int GetUpperLimit(int power)
        {
            bool found = false;
            int cnt = 2;
            var max = (int)Math.Pow(9, power);
            
            while(!found)
            {
                var number = max * cnt;
                var digits = this._mathUtil.GetDigits(number);
                if (number > max * digits.Length)
                {
                    found = true;                    
                }
                else
                { 
                    cnt = cnt + 1;
                }                
            }

            return max * cnt;
        }
    }
}
