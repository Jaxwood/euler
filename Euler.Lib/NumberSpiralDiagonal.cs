using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class NumberSpiralDiagonal
    {
        public int GetDiagonalSum(int size)
        {
            var sum = 0;
            var cnt = 1;
            var modulus = 2;

            for (int i = 0; i < Math.Pow(size, 2); i++)
            {
                if (i % modulus == 0)
                {
                    sum += i+1;
                    cnt = cnt + 1;
                    if (cnt > 4)
                    {
                        modulus += 2;
                        cnt = 1;
                    }
                }                
            }

            return sum;
        }
    }
}
