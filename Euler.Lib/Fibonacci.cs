using Euler.Lib.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Euler.Lib
{
    public class Fibonacci
    {        
        private Dictionary<BigInteger, BigInteger> _memorizer = new Dictionary<BigInteger, BigInteger>();

        private ISpecification<BigInteger> _specification;

        public BigInteger GetTerm(int term)
        {            
            return this.Fib(term);
        }

        public BigInteger GetUntil(ISpecification<BigInteger> specification)
        {
            this._specification = specification;

            return FibUntil(0);
        }

        private BigInteger Fib(BigInteger term)
        {
            if (this._memorizer.ContainsKey(term)) return this._memorizer[term];

            if (term >= 2)
            {
                var fib = this.Fib(term - 1) + this.Fib(term - 2);
                this._memorizer.Add(term, fib);
                return fib;
            }
            if (term == 1) return 1;
            
            return 0;
        }

        private BigInteger FibUntil(BigInteger term)
        {
            var fib = this.Fib(term);
            
            while(!this._specification.IsSatisfiedBy(fib))
            {
                fib = this.Fib(term++);
            }

            return term-1;
        }
    }
}
