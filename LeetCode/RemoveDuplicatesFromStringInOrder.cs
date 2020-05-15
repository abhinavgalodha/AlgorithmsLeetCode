using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /*
     * https://leetcode.com/problems/remove-duplicate-letters/
     
        Given a string which contains only lowercase letters, remove duplicate letters so that every letter appears once and only once. You must make sure your result is the smallest in lexicographical order among all possible results.

        Example 1:
        
        Input: "bcabc"
        Output: "abc"
        
        Example 2:
        
        Input: "cbacdcbc"
        Output: "acdb"
        
     */
    public class RemoveDuplicatesFromStringInOrder
    {
        public string Removev1(string inputString)
        {
            var hashSetOfCharacters = new HashSet<char>();
            var listChars = new List<char>();
            var previousChar = ' ';
            foreach (var character in inputString)
            {
                if (character == ' ') continue;
                if (character == previousChar) continue;

                if (hashSetOfCharacters.Contains(character))
                {
                    if (character > listChars.Last())
                    {
                        listChars.Remove(character);
                        listChars.Add(character);
                    }
                    else
                    {
                        var tempList = new List<char>(listChars);
                        tempList.Remove(character);
                        tempList.Add(character);

                        string newString = new string(tempList.ToArray());
                        string currentString = new string(listChars.ToArray());

                        if (newString.CompareTo(currentString) < 0)
                        {
                            listChars = tempList;
                        }    
                    }
                }
                else
                {
                    hashSetOfCharacters.Add(character);
                    listChars.Add(character);
                }
            }
            return new string(listChars.ToArray());
        }

        public string Remove(string s)
        {
            Stack<char> stack = new Stack<char>();
            int[] count = new int[26];
            char[] arr = s.ToCharArray();
            foreach(char c in arr) {
                count[c-'a']++;
            }
            bool[] visited = new bool[26];
            foreach(char c in arr) {
                count[c-'a']--;
                if(visited[c-'a']) {
                    continue;
                }
                while(stack.Count > 0 && stack.Peek() > c && count[stack.Peek()-'a'] > 0) {
                    visited[stack.Peek()-'a'] = false;
                    stack.Pop();
                }
                stack.Push(c);
                visited[c-'a'] = true;
            }
            StringBuilder sb = new StringBuilder();
            while(stack.Count > 0) {
                sb.Append(stack.Pop());
            }
            return new string(sb.ToString().Reverse().ToArray());
        }
    }
    /*
     * Algorithm
     * Need to find duplicates, Which data structure? Use Dictionary
     * Traverse each character. If exists in Dictionary, then remove
     * If empty space then ignore
     */
}
