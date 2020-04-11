using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Day4MoveZeroes
    {
        /*
         * Question: 
         * Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the
         * non-zero elements.

            Example:

            Input: [0,1,0,3,12]
            Output: [1,3,12,0,0]

            Note:

                You must do this in-place without making a copy of the array.
                Minimize the total number of operations.
        */

        /// <exception cref="T:System.OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue"></see> elements.</exception>
        public void MoveAllZeroesInPlaceNoAdditionalArray(int[] nums)
        {
            var lengthOfArray = nums.Length;
            var zeroes = 0;
            for (var index = 0; index < lengthOfArray; index++)
            {
                var currentNumber = nums[index];
                
                if (currentNumber == 0)
                {
                    zeroes++;
                    continue;
                }
                
                //Swap with next number if next number is not zero
                nums[index-zeroes] = currentNumber;
                for (int i = 1; i <= zeroes; i++)
                {
                    nums[index - zeroes + i] = 0;    
                }
            }
        }

        public void MoveAllZeroesUsingAdditionalArray(int[] nums)
        {
            var lengthOfArray = nums.Length;
            var resultArray = new int[lengthOfArray];
            var resultIndex = 0;
            for (int i = 0; i < lengthOfArray; i++)
            {
                if (nums[i] != 0)
                {
                    resultArray[resultIndex] = nums[i];
                    resultIndex++;
                }
            }

            for (int i = 0; i < lengthOfArray; i++)
            {
                nums[i] = resultArray[i];
            }
        }

        public void MoveAllZeroesUsing2Pointers(int[] nums)
        {
            var lengthOfArray = nums.Length;
            var lastNonZeroIndex = 0;
            for (int index = 0; index < lengthOfArray; index++)
            {
                if (nums[index] != 0)
                {
                    nums[lastNonZeroIndex] = nums[index];
                    lastNonZeroIndex++;
                }
            }

            for (int zeroIndex = lastNonZeroIndex; zeroIndex < lengthOfArray; zeroIndex++)
            {
                nums[zeroIndex] = 0;
            }
        }

        public void MoveAllZeroesUsing2PointersOptimal(int[] nums)
        {
            for (int lastNonZeroFoundAt = 0, currentIndex = 0; currentIndex < nums.Length; currentIndex++) {
                if (nums[currentIndex] != 0)
                {
                    var temp = nums[currentIndex];
                    nums[currentIndex] = nums[lastNonZeroFoundAt];
                    nums[lastNonZeroFoundAt] = temp;
                    lastNonZeroFoundAt++;
                }
            }
        }
    }
}
