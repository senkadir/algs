using Algorithms.Sorting;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Sorting
{
    public class SelectionSortTests
    {
        [Fact]
        public void Selection_Sort_Sorting_Correctly_Test()
        {
            //Arrange
            List<int> numbersToSort = new List<int>
            {
                5,1,7,3,8,34,2
            };

            SelectionSort selection = new SelectionSort(numbersToSort);

            //Act
            selection.Sort();

            //Assert
            Assert.Equal(1, selection.Numbers[0]);
            Assert.Equal(2, selection.Numbers[1]);
            Assert.Equal(3, selection.Numbers[2]);
            Assert.Equal(5, selection.Numbers[3]);
            Assert.Equal(7, selection.Numbers[4]);
            Assert.Equal(8, selection.Numbers[5]);
            Assert.Equal(34, selection.Numbers[6]);
        }
    }
}
