using FluentAssertions;
using LeetCode;
using LeetCode.Test.Extension;
using System.Collections.Generic;
using Xunit;

namespace LeetCode.Test
{
    public class BinarySearchTreeTraversalTests
    {
        public static IEnumerable<object[]> TestData
            => new List<object[]>
            {
                //GetTreeNode(),
            };


        private static BinarySearchTreeTraversal.TreeNode GetTreeNode()
        {
            var treeNode = new BinarySearchTreeTraversal.TreeNode(3);
            var treeNode1 = new BinarySearchTreeTraversal.TreeNode(2, treeNode, null);
            var treeNode2 = new BinarySearchTreeTraversal.TreeNode(1,null,treeNode1);
            return treeNode2;
        }
        

        [Fact]
        public void BSTInOrderTraversal()
        {
            // Arrange
            var treeNode = GetTreeNode();

            // Act
            var bst = new BinarySearchTreeTraversal();
            var inOrderTraversal = bst.InorderTraversal(treeNode);
            

            // Assert
            var expectedResult = new List<int>() {1,3,2};
            inOrderTraversal.Should().BeEquivalentWithStrictOrderTo(expectedResult);
        }

        [Fact]
        public void BSTInOrderTraversalUsingStack()
        {
            // Arrange
            var treeNode = GetTreeNode();

            // Act
            var bst = new BinarySearchTreeTraversal();
            var inOrderTraversal = bst.InorderTraversalUsingStack(treeNode);
            

            // Assert
            var expectedResult = new List<int>() {1,3,2};
            inOrderTraversal.Should().BeEquivalentWithStrictOrderTo(expectedResult);
        }
    }
}
