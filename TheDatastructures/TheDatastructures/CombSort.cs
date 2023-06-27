using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDatastructures
{
    public static class CombSort
    {
        public static int[] Sort(int[] arr)
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
                    if (arr[i] > arr[i + gap])
                    {
                        int temp = arr[i];
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

