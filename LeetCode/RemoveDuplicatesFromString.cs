using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /*
     * https://www.geeksforgeeks.org/remove-duplicates-from-a-given-string/
     
        Remove duplicates from a given string
        Given a string S, the task is to remove all the duplicates in the given string.
     */
    public class RemoveDuplicatesFromString
    {
        public string Remove(string inputString)
        {
            var result = new StringBuilder();
            var hashSetOfCharacters = new HashSet<char>();

            foreach (var character in inputString)
            {
                if(character == ' ') continue;
		
                if(hashSetOfCharacters.Contains(character)) continue;
                hashSetOfCharacters.Add(character);
                result.Append(character);
            }
            return result.ToString();
        }
    }
    /*
     * Algorithm
     * Need to find duplicates, Which data structure? Use Dictionary
     * Traverse each character. If exists in Dictionary, then remove
     * If empty space then ignore
     */
}
