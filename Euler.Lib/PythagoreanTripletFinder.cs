using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class PythagoreanTripletFinder
    {
        public int[] GetTriplets(int sum)
        {
            for (int a = 2; a < sum; a++)
            {
                for (int b = a + 1; b < sum; b++)
                {
                    for (int c = b + 1; c < sum; c++)
                    {
                        if ((a + b + c) == sum && Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                        {
                            return new int[] { a, b, c };
                        }
                    }
                }
            }

            return new int[] { 0 };
        }
    }
}
