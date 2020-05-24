using FluentAssertions;
using LeetCode.Test.Extension;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Test
{
    public class ArithmeticSlicesTests
    {
        public static IEnumerable<object[]> TestData
            => new List<object[]>
            {
                new object[] {new int[] { 1, 1, 2, 5, 7 } , 0 } ,
                new object[] {new int[] {1,2,3,4} , 3 },
                new object[] {new int[] {1,2,3,8,9,10} , 2 },
                new object[] {new int[] {1, 3, 5, 7, 9} , 6 },
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void PositiveTests(int[] inputArray, int target)
        {
            var result  = new ArithmeticSlices413().NumberOfArithmeticSlices(inputArray);
            result.Should().Be(target);
        }

    }
}
