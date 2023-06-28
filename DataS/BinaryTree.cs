using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataS
{
    public class BinaryTreeNode<T>
    {
        public T Data { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; }
        public int Count { get; private set; }

        public BinaryTree()
        {
            Root = null;
            Count = 0;
        }

        public void Insert(T data)
        {
            var newNode = new BinaryTreeNode<T>(data);

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                InsertRecursively(Root, newNode);
            }

            Count++;
        }

        private void InsertRecursively(BinaryTreeNode<T> currentNode, BinaryTreeNode<T> newNode)
        {
            if (currentNode == null)
            {
                currentNode = newNode;
                return;
            }

            if (Comparer<T>.Default.Compare(newNode.Data, currentNode.Data) < 0)
            {
                if (currentNode.Left == null)
                {
                    currentNode.Left = newNode;
                }
                else
                {
                    InsertRecursively(currentNode.Left, newNode);
                }
            }
            else
            {
                if (currentNode.Right == null)
                {
                    currentNode.Right = newNode;
                }
                else
                {
                    InsertRecursively(currentNode.Right, newNode);
                }
            }
        }

        public bool Search(T data)
        {
            return SearchRecursively(Root, data);
        }

        private bool SearchRecursively(BinaryTreeNode<T> currentNode, T data)
        {
            if (currentNode == null)
            {
                return false;
            }

            if (EqualityComparer<T>.Default.Equals(currentNode.Data, data))
            {
                return true;
            }

            if (Comparer<T>.Default.Compare(data, currentNode.Data) < 0)
            {
                return SearchRecursively(currentNode.Left, data);
            }
            else
            {
                return SearchRecursively(currentNode.Right, data);
            }
        }
    }

}
