using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class MaximumPathFinder
    {
        private int _index;
        private int _take = 2;

        public int GetMax(int[][] triangle)
        {
            this._index = 0;
            int sum = 0;

            for (int i = 0; i < triangle.Length; i++ )
            {
                var arr = triangle[i];
                if (arr.Length == 1)
                {
                    sum += arr[0];
                }
                else
                {
                    var val = this.GetBestValue(i, triangle);
                    sum += val;
                    this._index = Array.IndexOf(arr, val);
                }
            }

            return sum;
        }

        private int GetBestValue(int current, int[][] triangle)
        {
            var index = 0;
            var best = 0;
            var candidates = triangle[current].Skip(this._index).Take(this._take).ToArray();
            var length = triangle.Length;

            // the last array
            if (current + 1 == length)
            {
                return candidates.Max(); 
            }

            for (int i = 0; i < candidates.Count(); i++)
            {
                int nextNextValue = 0;
                int nextNextNextValue = 0;
                int nextNextNextNextValue = 0;
                var nextValue = this.GetNextValue(triangle[current + 1], Array.IndexOf(triangle[current], candidates[i]));
                if ( length > current + 2)
                { 
                    nextNextValue = this.GetNextValue(triangle[current + 2], Array.IndexOf(triangle[current+1], nextValue));
                }
                if (length > current + 3)
                {
                    nextNextNextValue = this.GetNextValue(triangle[current + 3], Array.IndexOf(triangle[current + 2], nextNextValue));
                }
                if (length > current + 4)
                {
                    nextNextNextNextValue = this.GetNextValue(triangle[current + 4], Array.IndexOf(triangle[current + 3], nextNextNextValue));
                }
                var tmp = candidates[i] + nextValue + nextNextValue + nextNextNextValue + nextNextNextNextValue;
                            
                if (tmp > best)
                {
                    best = tmp;
                    index = i;
                }
            }

            return candidates[index];
        }

        private int GetNextValue(int[] next, int index)
        {
            return next.Skip(index).Take(2).Max();
        }
    }
}
