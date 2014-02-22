using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class NodeFactory
    {
        internal Node CreateNew()
        {
            return new Node
            {
                Id = Guid.NewGuid()
            };
        }

        internal Node CreateNew(Node parent)
        {
            var node = new Node
            {
                Id = Guid.NewGuid()
            };

            node.Parents.Add(parent);

            return node;
        }

        internal Node CreateNew(Node parent, Guid guid)
        {
            var node = new Node
            {
                Id = guid
            };

            node.Parents.Add(parent);

            return node;
        }

        public Node Create(int childs)
        {
            var parent = CreateNew();

            for (int i = 0; i < childs; i++)
            {
                var node = this.CreateNew(parent);
                parent.Children.Add(node);
            }

            return parent;
        }

        public IEnumerable<Node> CreateSiblingNode(Node parent)
        {
            Node sibling = null;

            if (this._siblingId == Guid.Empty)
            {
                this._siblingId = Guid.NewGuid();
                sibling = this.CreateNew(parent, this._siblingId);
            }
            else
            { 
                sibling = this.CreateNew(parent, this._siblingId);
                this._siblingId = Guid.Empty;
            }

            var nodes = new[] { this.CreateNew(parent), sibling };
            parent.Siblings.Add(sibling);

            return nodes;
        }

        public IEnumerable<Node> CreateChildNodes(Node parent)
        {
            // is it the root?
            if (parent.Parents.Any())
            {
                return this.CreateSiblingNode(parent);                
            }
            else
            {
                return new[] { this.CreateNew(parent), this.CreateNew(parent) };
            }
        }

        private Guid _siblingId = Guid.Empty;

        public Node CreateNodeHierachy(Node parent, int depth)
        {
            if (depth == 0) return parent;

            parent.Children.AddRange(this.CreateChildNodes(parent));
            depth = depth - 1;

            foreach (var item in parent.Children)
	        {                
		        this.CreateNodeHierachy(item, depth);
	        }            

            return parent;
        }
    }
}
