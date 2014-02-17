using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Lib
{
    public class PrimeUtil
    {
        public bool IsPrime(long number)
        {
            if (number <= 1) return false;
            if (number >= 2 && number <= 3) return true;

            var max = Convert.ToInt64(Math.Abs(Math.Sqrt(number)));
            var cnt = 2;
            while(cnt <= max)
            {
                if (number % cnt == 0) return false;
                cnt++;
            }

            return true;
        }
    }
}
