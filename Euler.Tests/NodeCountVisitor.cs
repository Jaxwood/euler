using Euler.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Tests
{
    public class NodeCountVisitor : IVisitor
    {
        int cnt = 0;
        int siblingCnt = 0;

        public void Visit(Node node)
        {
            cnt++;

            if (node.Siblings.Any())
            {
                siblingCnt++;
            }
        }

        public int Count 
        {
            get { return cnt - siblingCnt; }
        }
    }
}
