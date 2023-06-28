using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataS
{
    public static class BinarySearchLink
    {
        public static int Search(int[] data, int target)
        {
            int left = 0;
            int right = data.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (data[mid] == target)
                {
                    return mid; // Element found at index mid
                }
                else if (data[mid] < target)
                {
                    left = mid + 1; // Search in the right half
                }
                else
                {
                    right = mid - 1; // Search in the left half
                }
            }

            return -1; // Element not found
        }

        internal static int Search(ListBox outputListBox, int target)
        {
            throw new NotImplementedException();
        }
    }
}
