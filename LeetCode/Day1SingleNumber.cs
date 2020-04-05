using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Day1SingleNumber
    {
        /*
        Given a non-empty array of integers, every element appears twice except for one. Find that single one.

        Note:
        Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

        Example 1:

        Input: [2,2,1]
        Output: 1

        Example 2:

        Input: [4,1,2,1,2]
        Output: 4
        
        */

        /// <exception cref="T:System.InvalidOperationException">Number of elements should be more than 1.</exception>
        /// <exception cref="T:System.ArgumentNullException">Argument shouldn't be null.</exception>
        public static int FindElementThatAppearsOnceWhenAllOtherAppearsTwice(int[] numberArray)
        {
            _ = numberArray ?? throw new ArgumentNullException();

            if (numberArray.Length < 1 )
            {
                throw new InvalidOperationException();  
            }

            return numberArray.Aggregate((acc, star) => acc ^ star);

        }

        public static int FindElementThatAppearsOnceWhenAllOtherAppearsTwicev1(int[] numberArray)
        {
            _ = numberArray ?? throw new ArgumentNullException();

            if (numberArray.Length < 1 )
            {
                throw new InvalidOperationException();  
            }

            var runningNumber = 0;

            for (var index = 0; index < numberArray.Length; index++)
            {
                var number = numberArray[index];
                runningNumber = runningNumber ^ number;
            }

            return runningNumber;
        }

        public static int FindElementThatAppearsOnceWhenAllOtherAppearsTwicev2(int[] numberArray)
        {
            _ = numberArray ?? throw new ArgumentNullException();

            if (numberArray.Length < 1 )
            {
                throw new InvalidOperationException();  
            }

            Dictionary<int,int> dict = new Dictionary<int, int>(numberArray.Length/2);

            for (var index = 0; index < numberArray.Length; index++)
            {
                if (dict.ContainsKey(numberArray[index]))
                {
                    dict.Remove(numberArray[index]);
                }
                else
                {
                    dict.Add(numberArray[index], 0);
                }
            }

            return dict.First().Key;
        }


    }
}
