using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class DateFinder
    {
        public int GetMonthsWithDay(DateTime from, DateTime to, DayOfWeek day)
        {
            int cnt = 0;

            while (from != to)
            {
                if (from.DayOfWeek == day)
                {
                    cnt++;
                }

                from = from.AddMonths(1);
            }

            return cnt;
        }
    }
}
