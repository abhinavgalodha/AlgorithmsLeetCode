using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /* https://leetcode.com/problems/two-sum/
     Given an array of integers, return indices of the two numbers such that they add up to a specific target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.
        
        Example:
        
        Given nums = [2, 7, 11, 15], target = 9,
        
        Because nums[0] + nums[1] = 2 + 7 = 9,
        return [0, 1].


    */
    public class TwoSum
    {
        public int[] Calculate1(int[] nums, int target) {
            var result = new int[2];
        
            var dictIntegerIndex = new Dictionary<int,List<int>>(nums.Length);
            for(int index=0; index< nums.Length ; index++)
            {
                if(dictIntegerIndex.ContainsKey(nums[index]))
                {
                    dictIntegerIndex[nums[index]].Add(index);
                }
                else
                {
                    dictIntegerIndex.Add(nums[index], new List<int>(){ index});    
                }

            }
        
            for(int index=0; index< nums.Length ; index++)
            {
                var firstNumber = nums[index];
                var secondNumber = target - firstNumber;

                if(dictIntegerIndex.ContainsKey(secondNumber))
                {
                    var indexOfSecondElementArray = dictIntegerIndex[secondNumber];
                    var indexOfSecondElement = indexOfSecondElementArray.FirstOrDefault(x => x != index);
                    if (indexOfSecondElement == index || indexOfSecondElement == 0 )
                        continue;

                    result[0] = index;
                    result [1] = indexOfSecondElement;

                    break;
                }
            }
        
            return result;
        }

        public int[] Calculate(int[] nums, int target) {
            Dictionary<int, int> intStore = new Dictionary<int, int>();    
            for (int i=0; i<nums.Length; i++) {
                if (intStore.ContainsKey(target-nums[i])) {
                    return new int[] {intStore[target-nums[i]], i};
                } else {
                    intStore[nums[i]] = i;
                }
            }
            return null;
        }
    }
}
