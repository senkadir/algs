using Algorithms.Sorting;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Sorting
{
    public class InsertionSortTests
    {
        [Fact]
        public void Insertion_Sort_Sorting_Correctly_Test()
        {
            //Arrange
            List<int> numbersToSort = new List<int>
            {
                5,1,7,3,8,34,2
            };

            InsertionSort sorter = new InsertionSort(numbersToSort);

            //Act
            sorter.Sort();

            //Assert
            Assert.Equal(1, sorter.Numbers[0]);
            Assert.Equal(2, sorter.Numbers[1]);
            Assert.Equal(3, sorter.Numbers[2]);
            Assert.Equal(5, sorter.Numbers[3]);
            Assert.Equal(7, sorter.Numbers[4]);
            Assert.Equal(8, sorter.Numbers[5]);
            Assert.Equal(34, sorter.Numbers[6]);
        }
    }
}
