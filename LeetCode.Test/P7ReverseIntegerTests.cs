using FluentAssertions;
using LeetCode.Test.Extension;
using System.Collections.Generic;
using Xunit;
using LeetCode;

namespace LeetCode.Test
{
    public class P7ReverseIntegerTests
    {
        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                new object[]{ 123 , 321},
                new object[]{ -123 , -321},
                new object[]{ 120 , 21},
                new object[]{ 0 , 0},
            };

        [Theory(Skip ="Timeout issue")]
        [MemberData(nameof(TestData))]
        public void PositiveTests(int inputNum, int expectedNumber)
        {
            var output = new P7ReverseInteger().Reverse(inputNum);
            output.Should().Be(expectedNumber);
        }
    }
}
