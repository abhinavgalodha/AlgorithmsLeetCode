using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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


        public int GetMaximumSubArray(int[] nums)
        {
            var maximumSum = nums[0];
            
            for (int index = 0; index < nums.Length; index++)
            {
                var sum = nums[index];
                if (maximumSum < sum)
                {
                    maximumSum = sum;
                }
                for (int innerIndex = index + 1; innerIndex < nums.Length; innerIndex++)
                {
                    sum = sum + nums[innerIndex];
                    if (maximumSum < sum)
                    {
                        maximumSum = sum;
                    }
                }
            }
            return maximumSum;
        }

        public int GetMaximumSubArrayUsingDp(int[] A)
        {
            int n = A.Length;
            int[] dp = new int[n];//dp[i] means the maximum subarray ending with A[i];
            dp[0] = A[0];
            int max = dp[0];
        
            for(int i = 1; i < n; i++){
                dp[i] = A[i] + (dp[i - 1] > 0 ? dp[i - 1] : 0);
                max = Math.Max(max, dp[i]);
            }
            return max;
        }


        public int GetMaximumSubArrayUsingDp1(int[] A) 
        {
            /*
             * this problem was discussed by Jon Bentley (Sep. 1984 Vol. 27 No. 9 Communications of the ACM P885)

                the paragraph below was copied from his paper (with a little modifications)

                algorithm that operates on arrays: it starts at the left end (element A[1]) and scans through to the right end (element A[n]), keeping track of the maximum sum subvector seen so far. The maximum is initially A[0]. Suppose we've solved the problem for A[1 .. i - 1]; how can we extend that to A[1 .. i]? The maximum
                sum in the first I elements is either the maximum sum in the first i - 1 elements (which we'll call MaxSoFar), or it is that of a subvector that ends in position i (which we'll call MaxEndingHere).
             */

            int maxSoFar=A[0], maxEndingHere=A[0];
            for (int i=1;i<A.Length;i++){
                maxEndingHere= Math.Max(maxEndingHere + A[i], A[i]);
                maxSoFar=Math.Max(maxSoFar, maxEndingHere);	
            }
            return maxSoFar;
        }
    }
}
