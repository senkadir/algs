using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public class BubbleSort
    {
        public List<int> Numbers { get; }

        public BubbleSort(List<int> numbers)
        {
            Numbers = numbers ?? throw new ArgumentNullException(nameof(numbers));
        }

        public void Sort()
        {
            int temp;

            for (int i = 0; i <= Numbers.Count - 2; i++)
            {
                for (int j = 0; j <= Numbers.Count - 2; j++)
                {
                    if (Numbers[j] > Numbers[j + 1])
                    {
                        temp = Numbers[j + 1];
                        Numbers[j + 1] = Numbers[j];
                        Numbers[j] = temp;
                    }
                }
            }
        }
    }
}