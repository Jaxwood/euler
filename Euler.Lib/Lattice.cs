using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class Lattice
    {

        private bool _increment = true;
        private int _size;
        
        public Lattice(int size)
        {
            this._size = size;
        }

        public int GetPaths()
        {
            return 0;
        }


        private Node AddNodes(Node node, int times)
        {
            if (times == 0) return node;
            if (times > this._size) this._increment = false;

            for (int i = 0; i < times; i++)
            {
                var child = new Node();
                child.Parents.Add(node);
                node.Children.Add(child);
            }

            if ( this._increment )
                ++times;
            else
                --times;

            foreach (var n in node.Children)
            {
                return AddNodes(n, times);
            }

            return node;
        }        
    }
}
