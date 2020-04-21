using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using LeetCode.Test.BaseTypes;
using LeetCode.Test.Extension;
using Xunit;

namespace LeetCode.Test
{
    public class Day6GroupAnagramsTest
    {
        public static IEnumerable<object[]> TestData
            => new List<object[]>
            {
                new object[]
                {
                    new string[] {"eat", "tea", "tan", "ate", "nat", "bat"} ,
                    new List<List<string>>() { new List<string>(){"ate","eat","tea"},
                         new List<string>(){ "nat","tan"},
                        new List<string>(){"bat"}}
                },
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void GroupAnagramTest(string[] inputArray, List<List<string>> groupOfAnagrams)
        {
            var result  = new Day6GroupAnagrams().GetAnagramsGroup(inputArray);
            result.Should().BeEquivalentTo(groupOfAnagrams);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void GetAnagramsOptimizedArrayAndDict(string[] inputArray, List<List<string>> groupOfAnagrams)
        {
            var result  = new Day6GroupAnagrams().GetAnagramsOptimizedArrayAndDict(inputArray);
            result.Should().BeEquivalentTo(groupOfAnagrams);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void GetAnagramsUsingCountSort(string[] inputArray, List<List<string>> groupOfAnagrams)
        {
            var result  = new Day6GroupAnagrams().GetAnagramsUsingCountSort(inputArray);
            result.Should().BeEquivalentTo(groupOfAnagrams);
        }

    }
}
