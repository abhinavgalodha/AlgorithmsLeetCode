using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /* 413. Arithmetic Slices
     * https://leetcode.com/problems/arithmetic-slices/
    A sequence of number is called arithmetic if it consists of at least three elements and if the difference between any two consecutive elements is the same.

    For example, these are arithmetic sequence:

    1, 3, 5, 7, 9
    7, 7, 7, 7
    3, -1, -5, -9

    The following sequence is not arithmetic.

    1, 1, 2, 5, 7


    A zero-indexed array A consisting of N numbers is given. A slice of that array is any pair of integers (P, Q) such that 0 <= P < Q < N.

    A slice (P, Q) of array A is called arithmetic if the sequence:
    A[P], A[p + 1], ..., A[Q - 1], A[Q] is arithmetic. In particular, this means that P + 1 < Q.

    The function should return the number of arithmetic slices in the array A.

    Example:

    A = [1, 2, 3, 4]

    return: 3, for 3 arithmetic slices in A: [1, 2, 3], [2, 3, 4] and [1, 2, 3, 4] itself.
    */
    public class ArithmeticSlices413
    {
        public int NumberOfArithmeticSlices(int[] A)
        {
            // 1. Check the length , if less than 3, then return 0;
            var numbersLength = A.Length;
            if (numbersLength < 3)
            {
                return 0;
            }

            var numberOfSlices = 0;

            // Calculate the difference between consecutive numbers
            var diffArray = new int[numbersLength - 1];
            for (int index = 0; index < numbersLength - 1  ; index++)
            {
                diffArray[index] = A[index+1] - A[index];
            }

            // iterate and check how many arithmetic slices found
            for (int index = 0; index < numbersLength - 2; index++)
            {
                var previousDiff = diffArray[index];
                for (int j = index + 1; j < numbersLength - 1; j++)
                {
                    var currentDiff = diffArray[j];
                    if (previousDiff == currentDiff)
                    {
                        numberOfSlices++;
                    }
                    else
                    {
                        break;
                    }
                    
                }
            }
            return numberOfSlices;

        }
    }
}
