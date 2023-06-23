using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataS
{
    internal class BinarySearchHashTable
    {
        public static bool HashTableBinarySearch(Hashtable data, int target)
        {
          List<int> values = GetHashtableValues(data);
           values.Sort();
           return BinarySearchAlgorithm(values, target);
        }

        private static List<int> GetHashtableValues(Hashtable data)
        {
           List<int> values = new List<int>();

             foreach (var value in data.Values)
            {
                if (value is int)
                {
                    values.Add((int)value);
                }
            }

         return values;
        }

        private static bool BinarySearchAlgorithm(List<int> sortedValues, int target)
        {
            int left = 0;
            int right = sortedValues.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (sortedValues[mid] == target)
                {
                    return true;
                }
                else if (sortedValues[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

         return false;
        }
    }
}
