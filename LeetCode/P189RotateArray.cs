using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{   /*
     * URL - https://leetcode.com/problems/rotate-array/
     * Given an array, rotate the array to the right by k steps, where k is non-negative.

        Follow up:

            Try to come up as many solutions as you can, there are at least 3 different ways to solve this problem.
            Could you do it in-place with O(1) extra space?

         

        Example 1:

        Input: nums = [1,2,3,4,5,6,7], k = 3
        Output: [5,6,7,1,2,3,4]
        Explanation:
        rotate 1 steps to the right: [7,1,2,3,4,5,6]
        rotate 2 steps to the right: [6,7,1,2,3,4,5]
        rotate 3 steps to the right: [5,6,7,1,2,3,4]

    */ 
    public class P189RotateArray
    {
        public void Rotate(int[] nums, int k) 
        {
            if (nums.Length == 1)
            {
                return;
            }

            var rotatedArray = new int[nums.Length];
            Array.Copy(nums, rotatedArray, nums.Length);
        
            var indexInOriginalArray = k;
        
            for(int index = 0; index < nums.Length; index++)
            {
                nums[indexInOriginalArray] = rotatedArray[index];
                indexInOriginalArray++;

                if(indexInOriginalArray == nums.Length)
                {
                    indexInOriginalArray = 0;
                }
            }
        }
    }
}
