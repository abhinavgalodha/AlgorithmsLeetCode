using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace LeetCode.Test
{
    public class RemoveDuplicateFromStringTests
    {
        public static IEnumerable<object[]> TestData
            => new List<object[]>
            {
                new object[] {"abcd" , "abc" },
                new object[] {"cbacdcbc" , "acdb" },
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void PositiveTests(string inputstring, string expectedResult)
        {
            var result  = new RemoveDuplicatesFromString().Remove(inputstring);
            result.Should().Be(expectedResult);
        }
    }
}
