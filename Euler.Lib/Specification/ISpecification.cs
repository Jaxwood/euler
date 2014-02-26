using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Lib.Specification
{
    public interface ISpecification<T> where T : struct
    {
        bool IsSatisfiedBy(T cadidate);
    }
}
