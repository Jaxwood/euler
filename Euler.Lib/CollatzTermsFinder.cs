using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class CollatzTermsFinder
    {
        public long GetTerms(long number)
        {
            int cnt = 1;

            while (number > 1)
            {                
                if (number % 2 == 0)
                {
                    number = number / 2;
                }
                else
                {
                    number = ((number * 3) + 1);
                }
                cnt++;
            }

            return cnt;
        }

        public long GetLargestTermBelowNumber(long number)
        {
            long largestTerm = 0;
            long largestNumber = 0;
            
            while(number > 1)
            {
                var terms = this.GetTerms(number);
                if (terms > largestTerm)
                {
                    largestNumber = number;
                    largestTerm = terms;
                }
                number = number - 1;
            }

            return largestNumber;
        }
    }
}
