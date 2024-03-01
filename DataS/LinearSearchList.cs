using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataS
{
    // Generic Node class
    class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    // Generic LinearSearchList class
    class LinearSearchList<T>
    {
        private Node<T> head;

        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public int LinearSearch(T target)
        {
            int index = 0;
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(target))
                    return index;
                current = current.Next;
                index++;
            }
            return -1;
        }
    }
}
