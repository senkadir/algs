using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class BinaryTreeTests
    {
        [Fact]
        public void Insert_Test()
        {
            //Arrange
            BinaryTree tree = new BinaryTree();

            List<int> values = new List<int>
            {
                0,3,2,7,4,9,1
            };

            //Act
            values.ForEach(x => tree.Insert(x));

            //Assert
            Assert.NotNull(tree.Root);
            Assert.Equal(0, tree.Root.Value);
        }
    }
}
