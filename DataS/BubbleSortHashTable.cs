using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataS
{
   
        internal class BubbleSortHashTable
        {
            public static void SortHashtableValues(Hashtable data)
            {
                List<int> values = GetHashtableValues(data);
                BubbleSortAlgorithm(values);
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

            private static void BubbleSortAlgorithm(List<int> values)
            {
                int n = values.Count;
                bool swapped;

                for (int i = 0; i < n - 1; i++)
                {
                    swapped = false;

                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (values[j] > values[j + 1])
                        {
                            int temp = values[j];
                            values[j] = values[j + 1];
                            values[j + 1] = temp;
                            swapped = true;
                        }
                    }

                    if (!swapped)
                        break;
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

