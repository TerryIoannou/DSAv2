﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataS
{
    public class MyLinkList<T>
    {
        private LinkedList<T> linkedList;
        private LinkedListNode<T> firstNode;

        public MyLinkList()
        {
            linkedList = new LinkedList<T>();
        }

        public void AddFirst(T value)
        {
            LinkedListNode<T> newNode = linkedList.AddFirst(value);
            if (linkedList.Count == 1)
                firstNode = newNode;
        }

        public void AddLast(T value)
        {
            LinkedListNode<T> newNode = linkedList.AddLast(value);
            if (linkedList.Count == 1)
                firstNode = newNode;
        }

        public bool Remove(T value)
        {
            bool removed = linkedList.Remove(value);
            if (removed && linkedList.Count == 0)
                firstNode = null;
            return removed;
        }

        public bool Contains(T value)
        {
            return linkedList.Contains(value);
        }

        public void Clear()
        {
            linkedList.Clear();
            firstNode = null;
        }

        public T[] ToArray()
        {
            return linkedList.ToArray();
        }

        public int Count => linkedList.Count;

        public LinkedListNode<T> GetFirstNode()
        {
            return firstNode;
        }
    }

}
