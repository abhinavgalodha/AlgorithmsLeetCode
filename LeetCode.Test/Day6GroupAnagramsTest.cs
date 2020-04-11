using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
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

    }
}
