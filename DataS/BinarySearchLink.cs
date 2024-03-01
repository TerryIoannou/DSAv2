using System;
using System.Collections.Generic;

namespace DataS
{
    public static class BinarySearchLink
    {
        public static int Search<T>(IList<T> data, T target, Comparer<T> comparer = null)
        {
            if (comparer == null)
                comparer = Comparer<T>.Default;

            int left = 0;
            int right = data.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                int comparisonResult = comparer.Compare(data[mid], target);

                if (comparisonResult == 0)
                    return mid; // Element found at index mid

                if (comparisonResult < 0)
                    left = mid + 1; // Search in the right half
                else
                    right = mid - 1; // Search in the left half
            }

            return -1; // Element not found
        }
    }
}
