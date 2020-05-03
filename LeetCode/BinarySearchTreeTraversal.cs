using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
    public class BinarySearchTreeTraversal
    {
        /*
         Given a binary tree, return the inorder traversal of its nodes' values.

            Example:
            
            Input: [1,null,2,3]
               1
                \
                 2
                /
               3
            
            Output: [1,3,2]
            
            Follow up: Recursive solution is trivial, could you do it iteratively?

         */

        // Definition for a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public IList<int> InorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            if (root != null)
            {
                // Left, Root, Right
                list.AddRange(InorderTraversal(root.left));
                list.Add(root.val);
                list.AddRange(InorderTraversal(root.right));
            }
            return list;
        }

        public IEnumerable<int> InorderTraversalUsingStack(TreeNode root)
        {
            // Initialize the Traversal Point
            // Initialize the empty stack to store a list of the Tree Nodes to traverse.
            // The Height of the Stack would depend on the height of the Tree.
            var currentNode = root;
            var stackOfInt = new Stack<TreeNode>();

            //Traverse the Tree
            while (currentNode != null ||
                   stackOfInt.Count > 0)
            {
                // Traverse the Leftmost node until no more left nodes
                while (currentNode != null)
                {
                    stackOfInt.Push(currentNode);
                    currentNode = currentNode.left;
                }

                // Reached the end of the left Node, no more left nodes to process, So consume it.
                currentNode = stackOfInt.Pop();

                // Yield return so that the operation is lazy
                yield return currentNode.val;

                // Move to next
                currentNode = currentNode.right;
            }
        }
    }
}