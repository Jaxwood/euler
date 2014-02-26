using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Lib.Specification
{
    public class FibonacciSumSpecification : ISpecification<BigInteger>
    {
        private BigInteger _result = BigInteger.Zero;
        private BigInteger _max;

        public FibonacciSumSpecification(BigInteger max)
        {
            this._max = max;
        }

        public bool IsSatisfiedBy(BigInteger cadidate)
        {
            if (cadidate > this._max) return true;

            if (cadidate % 2 == 0)
            {
                this._result = BigInteger.Add(this._result, cadidate);
            }

            return false;
        }

        public BigInteger Result
        {
            get { return this._result; }
        }
    }
}
