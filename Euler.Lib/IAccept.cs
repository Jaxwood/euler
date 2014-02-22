using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public interface IAccept
    {
        void Accept(IVisitor visitor);
    }
}
