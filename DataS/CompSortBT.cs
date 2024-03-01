using System;
using System.Collections.Generic;

namespace DataS
{
    public static class CompSortBT
    {
        public static void CombSort<T>(BinaryTree<T> data) where T : IComparable<T>
        {
            bool swapped = true;
            double gap = data.Count;
            BinaryTreeNode<T> rootNode = data.Root;

            while (gap > 1 || swapped)
            {
                gap /= 1.247330950103979;

                if (gap < 1)
                    gap = 1;

                swapped = false;
                rootNode = CombSortPass(rootNode, gap, out swapped);
            }

            data.Root = rootNode;
        }

        private static BinaryTreeNode<T> CombSortPass<T>(BinaryTreeNode<T> currentNode, double gap, out bool swapped) where T : IComparable<T>
        {
            BinaryTreeNode<T> root = currentNode;
            swapped = false;
            int count = GetNodeCount(currentNode);

            for (int i = 0; i + (int)gap < count; i++)
            {
                BinaryTreeNode<T> currentNodeI = FindNodeByIndex(root, i);
                BinaryTreeNode<T> currentNodeIGap = FindNodeByIndex(root, i + (int)gap);

                if (currentNodeI.Data.CompareTo(currentNodeIGap.Data) > 0)
                {
                    T temp = currentNodeI.Data;
                    currentNodeI.Data = currentNodeIGap.Data;
                    currentNodeIGap.Data = temp;
                    swapped = true;
                }
            }

            return root;
        }

        private static int GetNodeCount<T>(BinaryTreeNode<T> currentNode)
        {
            if (currentNode == null)
                return 0;

            return GetNodeCount(currentNode.Left) + 1 + GetNodeCount(currentNode.Right);
        }

        private static BinaryTreeNode<T> FindNodeByIndex<T>(BinaryTreeNode<T> currentNode, int index)
        {
            int leftSubtreeCount = GetNodeCount(currentNode.Left);

            if (index < leftSubtreeCount)
                return FindNodeByIndex(currentNode.Left, index);
            else if (index == leftSubtreeCount)
                return currentNode;
            else
                return FindNodeByIndex(currentNode.Right, index - (leftSubtreeCount + 1));
        }
    }
}
