using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataS
{
    public static class BubbleSortBT
    {
        public static void BubbleSort(BinaryTree<int> data)
        {
            List<int> elements = InorderTraversal(data.Root);

            int n = elements.Count;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (elements[j] > elements[j + 1])
                    {
                        int temp = elements[j];
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

        private static List<int> InorderTraversal(BinaryTreeNode<int> currentNode)
        {
            List<int> elements = new List<int>();
            InorderTraversalRecursively(currentNode, elements);
            return elements;
        }

        private static void InorderTraversalRecursively(BinaryTreeNode<int> currentNode, List<int> elements)
        {
            if (currentNode == null)
                return;

            InorderTraversalRecursively(currentNode.Left, elements);
            elements.Add(currentNode.Data);
            InorderTraversalRecursively(currentNode.Right, elements);
        }

        private static BinaryTreeNode<int> BuildTree(List<int> elements, int start, int end)
        {
            if (start > end)
                return null;

            int mid = (start + end) / 2;
            BinaryTreeNode<int> node = new BinaryTreeNode<int>(elements[mid]);

            node.Left = BuildTree(elements, start, mid - 1);
            node.Right = BuildTree(elements, mid + 1, end);

            return node;
        }
    }
}
