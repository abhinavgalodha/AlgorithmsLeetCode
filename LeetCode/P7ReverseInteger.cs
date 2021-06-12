/*
Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

Example 1:

Input: x = 123
Output: 321
*/

using System;
namespace LeetCode
{
    public class P7ReverseString
    {
        public int Reverse(int x) {
        
        var result = 1;
        var multiplicationFactor = Math.Pow(10, x.ToString().Length);
        var remainingNumber = x;
        while(remainingNumber/10 == 0)
        {
           result = (int) (result * multiplicationFactor) + x % 10;
           Console.WriteLine(result);
           multiplicationFactor = multiplicationFactor/10;
           remainingNumber = remainingNumber/10;   
        }
        return result;
    }
    }
}

