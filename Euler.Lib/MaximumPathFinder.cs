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
            int take = 2;
            int sum = 0;
            // triangle = triangle.Reverse().ToArray();
            foreach (var arr in triangle)
            {
                if (arr.Length == 1) 
                {
                    sum += arr[0];
                }
                else
                {
                    var tmpArr = arr.Skip(index).Take(take);
                    var val = tmpArr.Max();
                    sum += val;
                    index = Array.IndexOf(arr, val);
                    // take = arr.Length == 2 ? 1 : 2;
                }
            }

            return sum;
        }
    }
}
