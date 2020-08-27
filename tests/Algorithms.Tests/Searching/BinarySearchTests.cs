using Algorithms.Searching;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Searching
{
    public class BinarySearchTests
    {
        [Fact]
        public void Binary_Search_Searhing_Correctly_Test()
        {
            //Arrange
            List<int> numbersToSearch = new List<int>
            {
                5,1,7,3,8,34,2
            };

            BinarySearch searcher = new BinarySearch(numbersToSearch);

            //Act
            var existForTrue = searcher.Search(34);

            var existForFalse = searcher.Search(100);

            //Assert
            Assert.True(existForTrue);
            Assert.False(existForFalse);
        }
    }
}
