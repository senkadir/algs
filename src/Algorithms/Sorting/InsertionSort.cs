using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public class InsertionSort
    {
        public List<int> Numbers { get; }

        public InsertionSort(List<int> numbers)
        {
            Numbers = numbers ?? throw new ArgumentNullException(nameof(numbers));
        }

        public void Sort()
        {
            for (int i = 0; i < Numbers.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (Numbers[j - 1] > Numbers[j])
                    {
                        int temp = Numbers[j - 1];
                        Numbers[j - 1] = Numbers[j];
                        Numbers[j] = temp;
                    }
                }
            }
        }
    }
}
