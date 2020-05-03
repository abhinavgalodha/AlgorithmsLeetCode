using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /*
        https://leetcode.com/problems/remove-k-digits/

    Given a non-negative integer num represented as a string, remove k digits from the number so that the new number is the smallest possible.

    Note:
    
        The length of num is less than 10002 and will be ≥ k.
        The given num does not contain any leading zero.
    
    Example 1:
    
    Input: num = "1432219", k = 3
    Output: "1219"
    Explanation: Remove the three digits 4, 3, and 2 to form the new number 1219 which is the smallest.


     */
    public class RemoveKDigits
    {
        public string GetSmallestNumberV1(string num, int k)
        {
            char[] array = num.ToCharArray(); // use array as stack
            int end = 0; // [0, end) of the array is result
            int i = 0;   // pointer traverse 0 to n - 1
            while (i < array.Length) {
                if (end == 0 || k == 0 || array[end - 1] <= array[i]) {
                    array[end++] = array[i++]; // add element into the stack
                } else {
                    while (k > 0 && end > 0 && array[end - 1] > array[i]) {
                        end--; // pop top of stack
                        k--;   // update number of elements needs to be removed 
                    }
                }
            }
            end -= k; // in case input is "11111" or "123456"
            // remove leading zeros
            int start = 0; 
            while (start < end && array[start] == '0') {
                start++; 
            }
            return start >= end ? "0" : new string(array.Skip(start).Take(end - start).ToArray()); 
        }

        public string GetSmallestNumberV2(string num, int k)
        {

            int digits = num.Length - k;
            char[] stk = new char[num.Length];
            int top = 0;
            // k keeps track of how many characters we can remove
            // if the previous character in stk is larger than the current one
            // then removing it will get a smaller number
            // but we can only do so when k is larger than 0
            for (int i = 0; i < num.Length; ++i)
            {
                char c = num[i];
                while (top > 0 && stk[top - 1] > c && k > 0)
                {
                    top -= 1;
                    k -= 1;
                }

                stk[top++] = c;
            }

            // find the index of first non-zero digit
            int idx = 0;
            while (idx < digits && stk[idx] == '0') idx++;

            return idx == digits ? "0" : new String(stk, idx, digits - idx);
        }

        /// <exception cref="T:System.ArgumentOutOfRangeException">K should be less than the length of string</exception>
        public string GetSmallestNumber(string num, int k)
        {
            // Guard Conditions
            if (String.IsNullOrWhiteSpace(num))
            {
                return string.Empty;
            }

            if (k < 0)
            {
                throw new ArgumentOutOfRangeException("The input parameter should be positive.");
            }

            var stringLength = num.Length;
            if (stringLength < k)
            {
                throw new ArgumentOutOfRangeException("K should be less than the length of string");
            }

            if (stringLength == k)
            {
                return "0";
            }

            var resultString = new char[stringLength - k];
            var stackDigits = new Stack<char>(stringLength - k);
            stackDigits.Push(num[0]);

            var digitsToRemove = k;
            for (int index = 1; index < stringLength; index++)
            {
                var digit = num[index];
                while (stackDigits.Count > 0 && 
                       digitsToRemove > 0 &&
                       digit < stackDigits.Peek())
                {
                    stackDigits.Pop();
                    digitsToRemove--;
                }
                stackDigits.Push(digit);
            }

            for (int index = 0; index < digitsToRemove; index++)
            {
                stackDigits.Pop();
            }

            //Remove leading zeros

            var lastIndex = stringLength - k - 1;
            foreach (var itemInStack in stackDigits)
            {
                resultString[lastIndex] = itemInStack;
                lastIndex--;
            }

            var nonZeroIndex = 0;
            for (int i = 0; i < resultString.Length; i++)
            {
                if (resultString[i] == '0')
                {
                    nonZeroIndex++;
                }
                else
                {
                    break;
                }
            }

            var resultSpan = resultString.AsSpan().Slice(nonZeroIndex, stringLength - k - nonZeroIndex);

            var result = new string(resultSpan);
            return String.IsNullOrWhiteSpace(result) ? "0" : result;

        }
    }

    /*
Invariants
    1. Whole number , num >= 0
    2. k <= num.Length < 10002
    3. no leading zero
    4. Can't change the order
    
I/p 
    1. Number {string}
    2. Digits {int}
    
O/p
    1. Smallest Number {int}
    
    
** Logic **
num = "1432219", k = 3


Approach 1 - O n2 * k
0
i,j,k
    1,2,
    2,3,
    3,4,
    
1 
    2,3
    3,4
    
2  
    3,4
    4,5
    
Approach 2 

Remainig digits will be 4

Largest
9999
1000
0000
Greedy Algorithm - Local peak
54321 - Most significant, k = 2, 54
12345 - k = 2, 123

5, 4
skip 5, 4, 


Start from Least Significant number
9

1432219

1,4,3,2,2,1,9

9,4,3,2,1



*/
}
