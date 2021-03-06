﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Day6GroupAnagrams
    {
        public IList<IList<string>> GetAnagramsGroup(string[] strs)
        {
            //1. Iterate over each element
            //2. sort the character array 
            //3. Add to dictionary, key = sorted array, value = array with [actual word]

            Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
            foreach (var eachString in strs)
            {
                var sortedChars = eachString.ToCharArray()
                    .OrderBy(x => x)
                    .ToArray();
                var sortedCharsString = new string(sortedChars);
                                                            
                if (dict.ContainsKey(sortedCharsString))
                {
                    var listOfAnagrams = dict[sortedCharsString];
                    listOfAnagrams.Add(eachString);
                }
                else
                {
                    var listStrings = new List<string>();
                    listStrings.Add(eachString);
                    dict.Add(sortedCharsString, listStrings);    
                }
            }
            return dict.Values.Select(x=>x).ToList();
        }

        public IList<IList<string>> GetAnagramsOptimizedArrayAndDict(string[] strs)
        {
            //1. Iterate over each element
            //2. sort the character array 
            //3. Add to dictionary, key = sorted array, value = array with [actual word]

            Dictionary<int, IList<string>> dict = new Dictionary<int, IList<string>>();
            foreach (var eachString in strs)
            {
                var sortedChars = eachString.ToCharArray();
                Array.Sort(sortedChars);
                
                var sortedCharsString = new string(sortedChars);
                var hashCode = sortedCharsString.GetHashCode();                                                            

                if (dict.ContainsKey(hashCode))
                {
                    var listOfAnagrams = dict[hashCode];
                    listOfAnagrams.Add(eachString);
                }
                else
                {
                    var listStrings = new List<string>();
                    listStrings.Add(eachString);
                    dict.Add(hashCode, listStrings);    
                }
            }
            return dict.Values.Select(x=>x).ToList();
        }

        public IList<IList<string>> GetAnagramsUsingCountSort(string[] strs)
        {
            Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
            foreach (var eachString in strs)
            {
                int[] arrIntsCount = new int[26];
                var chars = eachString.AsSpan();

                foreach (var eachChar in chars)
                {
                    arrIntsCount[eachChar - 'a']++;
                }

                var keyResult = arrIntsCount.Aggregate(new StringBuilder(), (first, second) => first.Append(second)).ToString();
                if (dict.ContainsKey(keyResult))
                {
                    dict[keyResult].Add(eachString);
                }
                else
                {
                    dict.Add(keyResult,new List<string>(){ eachString});
                }
            }
            return dict.Values.Select(x=>x).ToList(); 
        }
    }
}
