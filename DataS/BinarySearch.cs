using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataS
{
    public static class BinarySearchAlgorithm
    {
        public static int BinarySearch(ArrayList data, int target)
        {
            int left = 0;
            int right = data.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int midValue = (int)data[mid];

                if (midValue == target)
                    return mid;

                if (midValue < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1; // Target not found
        }
    }
}
