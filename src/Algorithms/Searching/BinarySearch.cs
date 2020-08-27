using System;
using System.Collections.Generic;

namespace Algorithms.Searching
{
    public class BinarySearch
    {
        public List<int> Numbers { get; }

        public BinarySearch(List<int> numbers)
        {
            Numbers = numbers ?? throw new ArgumentNullException(nameof(numbers));
        }

        public bool Search(int value)
        {
            int max = Numbers.Count - 1;
            int mid;
            int min = 0;

            while (min <= max)
            {
                mid = (min + max) / 2;

                if (Numbers[mid] == value)
                {
                    return true;
                }
                else
                {
                    if (value < Numbers[mid])
                    {
                        max = mid - 1;
                    }
                    else
                    {
                        min = mid + 1;
                    }
                }
            }

            return false;
        }
    }
}
