using System;
using System.Collections.Generic;

namespace DataS
{
    public static class BinarySearchAlgorithm
    {
        public static int BinarySearch(ArrayList<int> data, int target)
        {
            int left = 0;
            int right = data.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (data[mid] == target)
                    return mid;

                if (data[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        public static int BinarySearch(ArrayList<string> data, string target)
        {
            int left = 0;
            int right = data.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                int comparisonResult = string.Compare(data[mid], target);
                if (comparisonResult == 0)
                    return mid;

                if (comparisonResult < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }
    }
}
