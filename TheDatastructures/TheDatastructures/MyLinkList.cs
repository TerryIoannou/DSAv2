using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDatastructures
{

    public class MyLinkList<T>
    {
        private LinkedList<T> linkedList;

        public MyLinkList()
        {
            linkedList = new LinkedList<T>();
        }

        public void AddFirst(T value)
        {
            linkedList.AddFirst(value);
        }

        public void AddLast(T value)
        {
            linkedList.AddLast(value);
        }

        public bool Remove(T value)
        {
            return linkedList.Remove(value);
        }

        public bool Contains(T value)
        {
            return linkedList.Contains(value);
        }

        public void Clear()
        {
            linkedList.Clear();
        }

        public T[] ToArray()
        {
            return linkedList.ToArray();
        }

        public int Count => linkedList.Count;
    }
 }

