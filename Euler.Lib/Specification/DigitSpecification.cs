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
        public DigitSpecification(int size)
        {
            this._size = size;
        }

        public bool IsSatisfiedBy(BigInteger cadidate)
        {
            return Math.Floor(BigInteger.Log10(cadidate)+1) == this._size;
        }
    }
}
