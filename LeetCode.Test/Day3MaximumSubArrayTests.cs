using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Test
{
    public class Day3MaximumSubArrayTests
    {
        public static IEnumerable<object[]> TestData
            => new List<object[]>
            {
                new object[] {new int[] { -2,1,-3,4,-1,2,1,-5,4 } , 6},
                new object[] {new int[] { -2,1 } , 1},
                new object[] {new int[] { -1,0,-2  } , 0},
                new object[] {new int[] { -1,-5,-2 } , -1},
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void FindMaximumSubArrayPositive(int[] inputArray, int maxSum)
        {
            var actualResult = new Day3MaximumSubArray().GetMaximumSubArray(inputArray);
            actualResult.Should().Be(maxSum);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void FindMaximumSubArrayPositiveUsingDp(int[] inputArray, int maxSum)
        {
            var actualResult = new Day3MaximumSubArray().GetMaximumSubArrayUsingDp(inputArray);
            actualResult.Should().Be(maxSum);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void FindMaximumSubArrayPositiveUsingDp1(int[] inputArray, int maxSum)
        {
            var actualResult = new Day3MaximumSubArray().GetMaximumSubArrayUsingDp1(inputArray);
            actualResult.Should().Be(maxSum);
        }

    }
}
