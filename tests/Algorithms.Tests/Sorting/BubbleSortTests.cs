using Algorithms.Sorting;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Sorting
{
    public class BubbleSortTests
    {
        [Fact]
        public void Bubble_Sort_Sorting_Test()
        {
            //Arrange
            List<int> numbersToSort = new List<int>
            {
                5,1,7,3,8,34,2
            };

            List<int> numbersSorted = new List<int>
            {
                1,2,3,5,7,8,34
            };

            BubbleSort bubble = new BubbleSort(numbersToSort);

            //Act
            bubble.Sort();

            //Assert
            Assert.Equal(1, bubble.Numbers[0]);
            Assert.Equal(2, bubble.Numbers[1]);
            Assert.Equal(3, bubble.Numbers[2]);
            Assert.Equal(5, bubble.Numbers[3]);
            Assert.Equal(7, bubble.Numbers[4]);
            Assert.Equal(8, bubble.Numbers[5]);
            Assert.Equal(34, bubble.Numbers[6]);
        }
    }
}
