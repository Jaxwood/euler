using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Euler.Lib
{
    public class SumOfPow
    {
        private readonly int _con;

        public SumOfPow(int con)
        {
            this._con = con;
        }

        public int GetSum(int pow)
        {
            var result = BigInteger.Pow(this._con, pow);
            
            return result.ToString().Select(c => (int)Char.GetNumericValue(c)).Sum();
        }
    }
}
