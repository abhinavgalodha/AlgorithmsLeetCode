using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using LeetCode.Test.BaseTypes;
using Xunit;

namespace LeetCode.Test
{
    public class Day6GroupAnagramsTest : BaseTests
    {
        public static IEnumerable<object[]> TestData
            => new List<object[]>
            {
                new object[]
                {
                    new string[] {"eat", "tea", "tan", "ate", "nat", "bat"} ,
                    new List<List<string>>() { new List<String>(){"ate","eat","tea"},
                         new List<String>(){ "nat","tan"},
                        new List<String>(){"bat"}}
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
