﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataS
{
    public static class CombSorting
    {
        public static void CombSort(MyArrayList<int> data)
        {
            double gap = data.Count;
            bool swapped = true;

            while (gap > 1 || swapped)
            {
                gap /= 1.247330950103979;

                if (gap < 1)
                    gap = 1;

                int i = 0;
                swapped = false;

                while (i + (int)gap < data.Count)
                {
                    int igap = i + (int)gap;

                    if (data[i] > data[igap])
                    {
                        int temp = data[i];
                        data[i] = data[igap];
                        data[igap] = temp;
                        swapped = true;
                    }

                    i++;
                }
            }
        }
    }
}


