using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataS
{
    internal class CombSortHashTable
    {
        public static void SortHashtableValues(Hashtable data)
        {
            List<int> values = GetHashtableValues(data);
            CombSortAlgorithm(values);
            UpdateHashtableValues(data, values);
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

        private static void CombSortAlgorithm(List<int> values)
        {
            int n = values.Count;
            double gap = n;
            bool swapped = true;

            while (gap > 1 || swapped)
            {
                gap /= 1.247330950103979;

                if (gap < 1)
                    gap = 1;

                int i = 0;
                swapped = false;

                while (i + gap < n)
                {
                    int igap = i + (int)gap;

                    if (values[i] > values[igap])
                    {
                        int temp = values[i];
                        values[i] = values[igap];
                        values[igap] = temp;
                        swapped = true;
                    }

                    i++;
                }
            }
        }

        private static void UpdateHashtableValues(Hashtable data, List<int> sortedValues)
        {
            Hashtable sortedData = new Hashtable();

            foreach (int value in sortedValues)
            {
                foreach (var key in data.Keys)
                {
                    if (data[key] is int && (int)data[key] == value)
                    {
                        sortedData.Add(key, value);
                        break;
                    }
                }
            }

            data.Clear();
            foreach (var key in sortedData.Keys)
            {
                data.Add(key, sortedData[key]);
            }
        }
    }
}

