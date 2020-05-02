using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using LeetCode.Test.Extension;
using Xunit;

namespace LeetCode.Test
{
    public class TwoSumTests
    {
        public static IEnumerable<object[]> TestData
            => new List<object[]>
            {
                new object[] {new int[] {2, 7, 11, 15} , 9, new int[] {0,1} },
                new object[] {new int[] {3, 2, 4} , 6, new int[] {1,2} },
                new object[] {new int[] {1, 2, 3, 1, 2, 3} , 4, new int[] {0,2} },
                new object[] {new int[] {3,3} , 6, new int[] {0,1} },
                new object[] {new int[] {1, 3, 4, 2} , 6, new int[] {2,3} },
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void PositiveTests(int[] inputArray, int target, int[] expectedArray)
        {
            var result  = new TwoSum().CalculateV2(inputArray, target);
            result.Should().BeEquivalentWithStrictOrderTo(expectedArray);
        }

    }
}
