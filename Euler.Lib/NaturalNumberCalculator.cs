using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Lib
{
    public class NaturalNumberCalculator
    {

        public int[] GetAllNumbers(int[] multiples, int[] range)
        {
            return (from r in range
                    from m in multiples
                    where r % m == 0
                    select r)
                   .Distinct()
                   .ToArray();
        }
    }
}
