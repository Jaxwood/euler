using Euler.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Euler.Tests
{
    public class NodeTests
    {
        [Fact]
        public void ShouldBeEqualIfIdIsEqual()
        {
            var guid = Guid.NewGuid();
            var node = new Node() { Id = guid };
            var node2 = new Node() { Id = guid };

            Assert.Equal(node, node2);
        }

        [Fact]
        public void ShouldNotBeEqualIfIdIsNotEqual()
        {
            var node = new Node() { Id = Guid.NewGuid() };
            var node2 = new Node() { Id = Guid.NewGuid() };

            Assert.NotEqual(node, node2);
        }

        [Fact]
        public void ShouldShareASiblingNode()
        {
            var node1 = new Node() { Id = Guid.NewGuid() };
            var node2 = new Node() { Id = Guid.NewGuid() };

            var childNode = new Node() { Id = Guid.NewGuid() };

            node1.Siblings.Add(childNode);
            node2.Siblings.Add(childNode);

            Assert.Equal(node1.Siblings, node2.Siblings);
        }

        [Fact]
        public void ShouldShareParentNode()
        {
            var parent = new Node() { Id = Guid.NewGuid() };

            var node1 = new Node() { Id = Guid.NewGuid() };
            node1.Parents.Add(parent);

            var node2 = new Node() { Id = Guid.NewGuid() };
            node2.Parents.Add(parent);

            Assert.Equal(node1.Parents, node2.Parents);
        }
    }
}
