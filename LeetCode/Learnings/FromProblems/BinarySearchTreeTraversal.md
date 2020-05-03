# Binary Tree Traversal


## Approach

## 1. Recursive
Left, Node, Right.
Recursively

#### Time Complexity : O(N)
All elements are visited.

#### Space Complexity


### 2. Stack
* Keep Navigating to left most node and add to stack.
* When no more items on left, it means reached the leaf node.
* Use Stack to add items, so that the last leaf node is the first one to be removed.
* Once the left Leaf node is processed, then process the parent node and then the right node.
* The processing step for parent node in above step is not required as that node is either a left or right node of a tree. 
  Note that the root node is already added at the start.

#### Time Complexity : O(N)
All elements are visited.

#### Space Complexity : O(K)
Depends on the Height of the Tree (k)

## Learnings
1. Recursive Solutions use more space.
2. Iterative solutions may use less space than the recursive solutions.s
3. 


### Depth First Search using Stack
A stack can be used for the Traversal. The Height of the stack is equal to the Depth of the tree.
Once one level is evaluated, the items from Stack can be popped.


### Yield
using Yield in C# for collections rather than returning a list in memory.

## Time Taken to solve
Recursive - 15 mins
Stack - Had to look at the explanation 1 hours

## Able to solve the problem
Using Recursive Approach
