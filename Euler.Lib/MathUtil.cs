using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Lib
{
    public class MathUtil
    {
        public int GetSumOfDivisors(int number)
        {
            return (from y in Enumerable.Range(1, (int)number / 2)
                    where number % y == 0
                    select y).Sum();
        }
    }
}
