using System;
using System.Collections.Generic;

namespace DataS
{
    public static class CombSortLink
    {
        public static T[] Sort<T>(T[] arr) where T : IComparable<T>
        {
            int n = arr.Length;
            int gap = n;
            bool swapped = true;

            while (gap > 1 || swapped)
            {
                gap = GetNextGap(gap);

                swapped = false;

                for (int i = 0; i < n - gap; i++)
                {
                    if (arr[i].CompareTo(arr[i + gap]) > 0)
                    {
                        T temp = arr[i];
                        arr[i] = arr[i + gap];
                        arr[i + gap] = temp;
                        swapped = true;
                    }
                }
            }

            return arr;
        }

        private static int GetNextGap(int gap)
        {
            gap = (gap * 10) / 13;

            if (gap < 1)
            {
                return 1;
            }

            return gap;
        }
    }
}
