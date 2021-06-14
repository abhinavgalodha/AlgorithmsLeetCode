/*
Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

Example 1:

Input: x = 123
Output: 321


Algo
//1. Get the length of the string = len 
//2. Set multiplication factor = 10 exp len
//3. while the divisor is not zero
//4. Get the remainder = 3
//5. Multiply remainder by the multiplication factor from step2
//6. add to the result
//7. set the remaining number = number\10
//8.

Dry Run
1. 2                                
2. 100
3. 123/10 = 12 | false
4. 123%10 = 3
5. 3 * 100 = 300
6. 0 + 300 = 300
7. number = 12

3.
12/10 = 1 | false
12%10 = 2
2*10 = 20
300 + 20 = 320
number = 1

*/



using System;
namespace LeetCode
{
    public class P7ReverseInteger
    {
        public int Reverse(int x)
        {
            var result = 0;
            var multiplicationFactor = Math.Pow(10, x.ToString().Length);

            var remainingNumber = x;
            var remainder = 0;
            var quotient = x;

            while (quotient != 0)
            {
                remainder = quotient % 10;
                quotient = x / 10;
                result = (int)(result + (remainder * multiplicationFactor));
                multiplicationFactor = multiplicationFactor / 10;
            }
            return result;
        }
    }
}

