using System.Collections.Generic;
using Xunit;
using FluentAssertions;
using LeetCode.Test.Extension;

namespace LeetCode.Test
{
    public class P338CountingBitsTests
    {
        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                new object[]{ 2 , new int[] {0,1,1} },
                new object[]{ -123 ,new int[] {0,1,1,2,1,2} },
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void PositiveTests(int inputNum, int[] expectedArray)
        {
            var output = new P338CountingBits().CountBits(inputNum);
            output.Should().BeEquivalentWithStrictOrderTo(expectedArray);
        }
    }
}
