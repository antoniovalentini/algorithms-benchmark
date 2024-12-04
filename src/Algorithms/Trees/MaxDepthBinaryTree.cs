using System;
using System.Collections.Generic;
using CodingChallengeCollection.DataStructures.Trees;

namespace CodingChallengeCollection.Algorithms.Trees;

public static class MaxDepthBinaryTree
{
    public static int MaxDepthRec(TreeNode? root)
    {
        if (root == null) return 0;
        var leftDepth = MaxDepthRec(root.left);
        var rightDepth = MaxDepthRec(root.right);
        return Math.Max(leftDepth, rightDepth) + 1;
    }

    public static int MaxDepthIter(TreeNode? root)
    {
        if (root == null) return 0;

        var maxDepth = 0;
        Stack<(TreeNode node, int depth)> stack = new();
        stack.Push((root, 1));

        while (stack.Count > 0) {
            var (currentNode, currentDepth) = stack.Pop();

            // Update max depth if necessary
            if (currentDepth > maxDepth) {
                maxDepth = currentDepth;
            }

            // Push children onto the stack with incremented depth
            if (currentNode.left != null) {
                stack.Push((currentNode.left, currentDepth + 1));
            }
            if (currentNode.right != null) {
                stack.Push((currentNode.right, currentDepth + 1));
            }
        }

        return maxDepth;
    }
}
