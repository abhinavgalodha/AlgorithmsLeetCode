using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using LeetCode.Test.Extension;
using Xunit;

namespace LeetCode.Test
{
    public class RemoveKDigitsTests
    {
        public static IEnumerable<object[]> TestData
            => new List<object[]>
            {
                new object[] {"1432219" , 3, "1219" },
                new object[] {"10200" , 1, "200" },
                new object[] {"10" , 2, "0" },
                new object[] {"12345" , 2, "123" },
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void PositiveTests(string inputstring, int digitsToRemove, string expectedResult)
        {
            var result  = new RemoveKDigits().GetSmallestNumber(inputstring, digitsToRemove);
            result.Should().Be(expectedResult);
        }

    }
}
