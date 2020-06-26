using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class P1143LongestCommonSubsequence
    {
        /*
         * URL : https://leetcode.com/problems/longest-common-subsequence/
         * 
            Given two strings text1 and text2, return the length of their longest common subsequence.
            A subsequence of a string is a new string generated from the original string with some characters(can be none) deleted without changing the relative order of the remaining characters. (eg, "ace" is a subsequence of "abcde" while "aec" is not). A common subsequence of two strings is a subsequence that is common to both strings.
            
            If there is no common subsequence, return 0.
            
            Example 1:
            
            Input: text1 = "abcde", text2 = "ace" 
            Output: 3  
            Explanation: The longest common subsequence is "ace" and its length is 3.
            
            Example 2:
            
            Input: text1 = "abc", text2 = "abc"
            Output: 3
            Explanation: The longest common subsequence is "abc" and its length is 3.
            
            Example 3:
            
            Input: text1 = "abc", text2 = "def"
            Output: 0
            Explanation: There is no such common subsequence, so the result is 0.
            
            Constraints:
            
                1 <= text1.length <= 1000
                1 <= text2.length <= 1000
                The input strings consist of lowercase English characters only.
         */

        public int LongestCommonSubsequence(string firstSequence, string secondSequence)
        {
            // Other concerns while solving the problem
            // Case sensitivity.
            // Unicode
            int longestCommonSubsequnce = 0;
            bool matchFoundAtSamePosition = false;
            int secondSequenceStartIndex = 0;

            for (int indexFirstSequence = 0; indexFirstSequence < firstSequence.Length; indexFirstSequence++)
            {
                matchFoundAtSamePosition = false;
                char charInFirstSequence = firstSequence[indexFirstSequence];
                for (int indexSecondSequence = secondSequenceStartIndex; indexSecondSequence < secondSequence.Length; indexSecondSequence++)
                {
                    char charInSecondSequence = secondSequence[indexSecondSequence];
                    if (charInFirstSequence == charInSecondSequence)
                    {
                        longestCommonSubsequnce++;
                        secondSequenceStartIndex++;
                        matchFoundAtSamePosition = true;
                        break;
                    }
                }
                //if(matchFoundAtSamePosition)
                //{
                //    break;
                //}
            }
            return longestCommonSubsequnce;
        }
    }
}
