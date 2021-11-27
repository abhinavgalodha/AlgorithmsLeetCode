using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /*
     * Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n), ans[i] is the number of 1's in the binary representation of i.

        Example 1:
        
        Input: n = 2
        Output: [0,1,1]
        Explanation:
        0 --> 0
        1 --> 1
        2 --> 10
    */
    public class P338CountingBits
    {
        public int[] CountBits(int n)
        {

            if (n < 0)
                return new int[0];

            // Declare an output array whose length is n+1
            var answerArray = new int[n + 1];

            for (var i = 0; i <= n; i++)
            {
                var countBits = Convert.ToString(i, 2).Count(x => x == '1');
                answerArray[i] = countBits;
            }

            // ans[i] = Count of 1's
            // ans [i] =  get binary representation of a number

            return answerArray;
        }

        public int[] CountBits1(int n)
        {

            if (n < 0)
                return new int[0];

            // Declare an output array whose length is n+1
            var answerArray = new int[n + 1];

            for (var i = 0; i <= n; i++)
            {
                var countBits = Convert.ToString(i, 2).Count(x => x == '1');
                answerArray[i] = countBits;
            }

            // ans[i] = Count of 1's
            // ans [i] =  get binary representation of a number

            return answerArray;
        }
    }
}
