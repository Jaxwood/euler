using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class LargestProductFinder
    {
        private int _range;
        public LargestProductFinder(int range)
        {
            this._range = range;
        }

        public int GetLargestProduct(string series)
        {
            var myseries = this.ConvertToArray(series);
            int found = 0;
            for (int i = 0; i < myseries.Length; i++)
            {
                var product = myseries.Skip(i)
                                    .Take(this._range)
                                    .Aggregate(1, (a,c) => a *= c );

                if ( product > found)
                {
                    found = product;
                }                
            }
            return found;
        }

        private int[] ConvertToArray(string series)
        {
            return series.Select(c => (int)Char.GetNumericValue(c)).ToArray();
        }
    }
}
