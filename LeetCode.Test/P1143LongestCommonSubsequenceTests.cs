using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Test
{
    public class P1143LongestCommonSubsequenceTests
    {
        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                new object[]{ "abcde", "ace", 3 },
                new object[]{ "abc", "abc" },
                new object[]{ "abc", "def", 0 },
                new object[]{ "ABCDGH", "AEDFHR", 3 },
                new object[]{ "AGGTAB", "GXTXAYB", 4 },
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void PositiveTests(string firstSequence, string secondSequence, int expectedLength)
        {
            var actualResult = new P1143LongestCommonSubsequence().LongestCommonSubsequence(firstSequence, secondSequence);
            actualResult.Should().Be(expectedLength);
        }
    }
}
