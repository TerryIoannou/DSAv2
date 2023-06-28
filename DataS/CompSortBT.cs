using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataS
{
    public static class CompSortBT
    {
        public static void CombSort(BinaryTree<int> data)
        {
            bool swapped = true;
            double gap = data.Count;
            BinaryTreeNode<int> rootNode = data.Root;

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

        private static BinaryTreeNode<int> CombSortPass(BinaryTreeNode<int> currentNode, double gap, out bool swapped)
        {
            BinaryTreeNode<int> root = currentNode;
            swapped = false;
            int count = GetNodeCount(currentNode);

            for (int i = 0; i + (int)gap < count; i++)
            {
                BinaryTreeNode<int> currentNodeI = FindNodeByIndex(root, i);
                BinaryTreeNode<int> currentNodeIGap = FindNodeByIndex(root, i + (int)gap);

                if (currentNodeI.Data > currentNodeIGap.Data)
                {
                    int temp = currentNodeI.Data;
                    currentNodeI.Data = currentNodeIGap.Data;
                    currentNodeIGap.Data = temp;
                    swapped = true;
                }
            }

            return root;
        }

        private static int GetNodeCount(BinaryTreeNode<int> currentNode)
        {
            if (currentNode == null)
                return 0;

            return GetNodeCount(currentNode.Left) + 1 + GetNodeCount(currentNode.Right);
        }

        private static BinaryTreeNode<int> FindNodeByIndex(BinaryTreeNode<int> currentNode, int index)
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
