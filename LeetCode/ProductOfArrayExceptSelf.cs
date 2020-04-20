using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /*
     *  https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/530/week-3/3300/
     *  Given an array nums of n integers where n > 1,  return an array output such that output[i]
     *  is equal to the product of all the elements of nums except nums[i].

        Example:
        
        Input:  [1,2,3,4]
        Output: [24,12,8,6]
        
        Constraint: It's guaranteed that the product of the elements of any prefix or suffix of the array (including the whole array) fits in a 32 bit integer.
        
        Note: Please solve it without division and in O(n).
        
        Follow up:
        Could you solve it with constant space complexity? (The output array does not count as extra space for the purpose of space complexity analysis.)
     */
    public class ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums) 
        {
            var product = nums.Aggregate((accumulator, currentItem) => currentItem == 0 ? accumulator * 1 : accumulator * currentItem);
            var outputArray = new int[nums.Length];
        
            for(int index = 0 ; index < nums.Length; index++)
            {
                if (nums[index] == 0)
                {
                    continue;
                }
                outputArray[index] = product/nums[index];
            }
            return outputArray;
        }
    }
}
