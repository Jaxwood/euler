using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Lib
{
    public class Node : IEqualityComparer<Node>, IAccept
    {
        public Node()
        {
            this.Children = new List<Node>();
            this.Siblings = new List<Node>();
            this.Parents = new List<Node>();
        }
        public Guid Id { get; set; }
        public int Value { get; set; }
        public List<Node> Parents { get; set; }
        public List<Node> Children { get; set; }
        public List<Node> Siblings { get; set; }

        public override bool Equals(object obj)
        {
            return this.Equals(this, obj as Node);
        }

        public bool Equals(Node x, Node y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode(Node obj)
        {
            return obj.Id.GetHashCode();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var child in this.Children)
            {
                child.Accept(visitor);
            }            
        }
    }
}
