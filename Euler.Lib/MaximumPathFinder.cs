using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class MaximumPathFinder
    {
        public int GetMax(int[][] triangle)
        {
            int index = 0;
            int sum = 0;

            foreach (var arr in triangle)
            {
                if (arr.Length == 1) 
                {
                    sum += arr[0];
                }
                else
                {
                    var tmpArr = arr.Skip(index).Take(2);
                    var val = tmpArr.Max();
                    sum += val;
                    index = Array.IndexOf(arr, val);
                }
            }

            return sum;

            return 0;
        }
    }
}
