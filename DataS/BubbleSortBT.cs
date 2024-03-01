using System;
using System.Collections.Generic;

namespace DataS
{
    public static class BubbleSortBT
    {
        public static void BubbleSort<T>(BinaryTree<T> data) where T : IComparable<T>
        {
            List<T> elements = InorderTraversal(data.Root);

            int n = elements.Count;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (elements[j].CompareTo(elements[j + 1]) > 0)
                    {
                        T temp = elements[j];
                        elements[j] = elements[j + 1];
                        elements[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }

            data.Root = BuildTree(elements, 0, elements.Count - 1);
        }

        private static List<T> InorderTraversal<T>(BinaryTreeNode<T> currentNode)
        {
            List<T> elements = new List<T>();
            InorderTraversalRecursively(currentNode, elements);
            return elements;
        }

        private static void InorderTraversalRecursively<T>(BinaryTreeNode<T> currentNode, List<T> elements)
        {
            if (currentNode == null)
                return;

            InorderTraversalRecursively(currentNode.Left, elements);
            elements.Add(currentNode.Data);
            InorderTraversalRecursively(currentNode.Right, elements);
        }

        private static BinaryTreeNode<T> BuildTree<T>(List<T> elements, int start, int end)
        {
            if (start > end)
                return null;

            int mid = (start + end) / 2;
            BinaryTreeNode<T> node = new BinaryTreeNode<T>(elements[mid]);

            node.Left = BuildTree(elements, start, mid - 1);
            node.Right = BuildTree(elements, mid + 1, end);

            return node;
        }
    }
}
