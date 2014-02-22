using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Euler.Lib;
using Xunit.Extensions;

namespace Euler.Tests
{
    public class NodeFactoryTests
    {
        private NodeFactory _sut;
        public NodeFactoryTests()
        {
            this._sut = new NodeFactory();
        }

        [Fact]
        public void ShouldCreateNodeWithChildren()
        {
            var actual = this._sut.Create(2);

            Assert.Equal(2, actual.Children.Count);
        }

        [Fact]
        public void ShouldCreateChildNodes()
        {
            var actual = this._sut.CreateChildNodes(new Node());            

            Assert.Equal(2, actual.Count());
        }

        [Fact]
        public void ShouldCreateNodeWithCommonSibling()
        {
            var actual = this._sut.CreateSiblingNode(new Node());

            var firstNode = actual.First();
            var lastNode = actual.Last();

            Assert.Equal(firstNode.Siblings, lastNode.Siblings);            
        }

        [Fact]
        public void ShouldCreateNodeWithCommonChild()
        {
            var parent = new Node();
            var first = this._sut.CreateSiblingNode(parent);
            var second = this._sut.CreateSiblingNode(parent);
            
            Assert.Equal(first.SelectMany(c => c.Siblings), second.SelectMany(c => c.Siblings));
        }

        [Theory]
        [InlineData(3, 1)]
        [InlineData(6, 2)]
        [InlineData(10, 3)]
        public void ShouldCreateNodeHierachy(int expected, int depth)
        {
            var node = this._sut.CreateNodeHierachy(new Node(), depth);
            
            // count node in hierachy
            var nodeVisitor = new NodeCountVisitor();
            node.Accept(nodeVisitor);

            Assert.Equal(expected, nodeVisitor.Count);
        }
    }
}
