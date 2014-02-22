using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public interface IVisitor
    {
        void Visit(Node node);
    }
}
