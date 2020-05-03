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
    }
}