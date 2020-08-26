using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public class SelectionSort
    {
        public List<int> Numbers { get; }

        public SelectionSort(List<int> numbers)
        {
            Numbers = numbers ?? throw new ArgumentNullException(nameof(numbers));
        }

        public void Sort()
        {
            for (int i = 0; i < Numbers.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < Numbers.Count; j++)
                {
                    if (Numbers[j] < Numbers[min])
                    {
                        min = j;
                    }
                }

                int temp = Numbers[min];
                Numbers[min] = Numbers[i];
                Numbers[i] = temp;
            }
        }
    }
}
