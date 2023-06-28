using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataS
{
    public class MyArrayList<T>
    {
        private List<T> list;

        public MyArrayList()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public bool Remove(T item)  
        {
            return list.Remove(item);
        }

        public int Count
        {
            get { return list.Count; }
        }

        public T this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }
    }
}
