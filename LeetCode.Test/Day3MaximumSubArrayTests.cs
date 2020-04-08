using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Test
{
    public class Day3MaximumSubArrayTests
    {
        [Theory]
        [InlineData(new int[] { -2,1,-3,4,-1,2,1,-5,4 } , 6)]
        [InlineData(new int[] { -2,1 } , 1)]
        [InlineData(new int[] { -1,0,-2 } , 0)]
        public void FindMaximumSubArrayPositive(int[] inputArray, int maxSum)
        {
            var actualResult = new Day3MaximumSubArray().GetMaximumSubArray(inputArray);
            actualResult.Should().Be(maxSum);

            
        }
    }
}
