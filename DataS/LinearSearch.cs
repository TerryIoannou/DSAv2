using System;
using System.Collections.Generic;

namespace DataS
{
    public class LinearSearch
    {
        public static int LinearSearchAlgorithm<T>(IEnumerable<T> collection, T target)
        {
            int index = 0;
            foreach (var item in collection)
            {
                if (item.Equals(target))
                    return index;
                index++;
            }

            return -1;
        }
    }
}
