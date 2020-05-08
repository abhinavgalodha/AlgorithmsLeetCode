
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace LeetCode.Test
{
    public class RemoveDuplicateFromStringInOrderTests
    {
        public static IEnumerable<object[]> TestData
            => new List<object[]>
            {
                new object[] {"bcabc" , "abc" },
                new object[] {"cbacdcbc" , "acdb" },
                new object[] {"bbcaac" , "bac" },
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void PositiveTests(string inputstring, string expectedResult)
        {
            var result  = new RemoveDuplicatesFromStringInOrder().Remove(inputstring);
            result.Should().Be(expectedResult);
        }
    }
}
