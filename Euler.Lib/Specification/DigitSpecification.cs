using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Lib.Specification
{
    public class DigitSpecification : ISpecification<BigInteger>
    {
        private int _size;
        private BigInteger _result;
        public DigitSpecification(int size)
        {
            this._size = size;
            this._result = BigInteger.Zero;
        }

        public bool IsSatisfiedBy(BigInteger cadidate)
        {            
            if (Math.Floor(BigInteger.Log10(cadidate) + 1) == this._size)
            {
                return true;
            }

            this._result = BigInteger.Add(this._result, BigInteger.One);

            return false;
        }

        public BigInteger Result
        {
            get { return BigInteger.Subtract(this._result, BigInteger.One); }
        }
    }
}
