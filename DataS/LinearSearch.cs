using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataS
{
    class LinearSearch
    {
        public static int LinearSearchAlgorithm<T>(MyArrayList<T> arr, T target)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].Equals(target))
                    return i;
            }

            return -1;
        }
    }
}
