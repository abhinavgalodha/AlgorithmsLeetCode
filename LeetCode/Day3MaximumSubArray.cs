using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Day3MaximumSubArray
    {
        /*
         * Question: 
         * Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
            Example:
            Input: [-2,1,-3,4,-1,2,1,-5,4]
/.          Output: 6
            Explanation: [4,-1,2,1] has the largest sum = 6.

            Follow up:
            If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.
         */

        /*
         * 1. Iterate over the array.
         * 2. Store the Sum as first element. Sum = -2
         * 3. Add next number, if sum < previous Sum, then reset the starting element to the next element. 
         * 4. 
         * Old Sum = -2, New Sum = -1, Array = -2,1; start Index = 0 
         * Old Sum = -1, New Sum = -4, Array = -2,1,-3; start Index = 0 
         * Old Sum = -1, New Sum = 4, Array = -2,1,-3,4; start Index = 3
         * Old Sum = 4, New Sum = 3, Array = 4, -1; start Index = 3
         */


        public int GetMaximumSubArray(int[] array)
        {
            var maximumSum = array[0];
            var previousSum = maximumSum;
            var sum = array[0];
            
            for (int index = 0; index < array.Length; index++)
            {
                for (int innerIndex = index + 1; innerIndex < array.Length; innerIndex++)
                {
                    sum = sum + array[innerIndex];
                    if (maximumSum < sum)
                    {
                        maximumSum = sum;
                    }
                }
            }
            return maximumSum;
        }
    }
}
