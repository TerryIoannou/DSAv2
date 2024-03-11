//Decided to implement this primitively without using libraries (more fun)

using System;

namespace DataS
{
    public class LinkedListNode<T>
    {
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T value)
        {
            this.Value = value;
            this.Next = null;
        }
    }

    public class LinkedList<T>
    {
        private LinkedListNode<T> Head;

        public bool CompareBy(LinkedListNode<T> other)
        {
            return false;
        }

        public LinkedListNode<T> GetFirstNode()
        {
            return Head;
        }


        public void AddFirst(T data)
        {
            LinkedListNode<T> newLinkedListNode = new LinkedListNode<T>(data);
            newLinkedListNode.Next = Head;
            Head = newLinkedListNode;
        }

        public void AddLast(T data)
        {
            LinkedListNode<T> newLinkedListNode = new LinkedListNode<T>(data);
            if (Head == null)
            {
                Head = newLinkedListNode;
                return;
            }

            LinkedListNode<T> current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newLinkedListNode;
        }

        public void Display()
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public bool Search(T data)
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public bool Contains(T data)
        {
            return Search(data);
        }

        public void Remove(T data)
        {
            if (Head == null)
                return;

            if (Head.Value.Equals(data))
            {
                Head = Head.Next;
                return;
            }

            LinkedListNode<T> current = Head;
            while (current.Next != null)
            {
                if (current.Next.Value.Equals(data))
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }

        public T[] ToArray()
        {
            if (Head == null)
                return new T[0];

            int count = 0;
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }

            T[] array = new T[count];
            current = Head;
            for (int i = 0; i < count; i++)
            {
                array[i] = current.Value;
                current = current.Next;
            }

            return array;
        }
    }
}
