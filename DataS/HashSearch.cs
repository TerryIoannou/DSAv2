using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataS
{
    internal class HashSearch
    {
        public static bool PerformSearch(Hashtable data, int target)
        {
            int hash = target.GetHashCode();

            if (data.ContainsKey(hash))
            {
                ArrayList bucket = (ArrayList)data[hash];

                foreach (int item in bucket)
                {
                    if (item == target)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}

