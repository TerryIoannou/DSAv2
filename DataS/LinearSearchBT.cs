using System;
using System.Collections.Generic;

namespace DataS
{
    public class LinearSearchBT<T>
    {
        private BinaryTree<T> binaryTree;

        public LinearSearchBT(BinaryTree<T> tree)
        {
            binaryTree = tree;
        }

        public bool Search(T target)
        {
            return LinearSearchRecursively(binaryTree.Root, target);
        }

        private bool LinearSearchRecursively(BinaryTreeNode<T> currentNode, T target)
        {
            if (currentNode == null)
            {
                return false;
            }

            if (EqualityComparer<T>.Default.Equals(currentNode.Data, target))
            {
                return true;
            }

            return LinearSearchRecursively(currentNode.Left, target) || LinearSearchRecursively(currentNode.Right, target);
        }
    }
}
