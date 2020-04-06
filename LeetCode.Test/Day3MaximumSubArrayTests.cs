using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Test
{
    public class Day3MaximumSubArrayTests
    {
        [Fact]
        public void FindMaximumSubArrayPositive()
        {
            var inputArray = new int[] {-2,1,-3,4,-1,2,1,-5,4};
            var expectedSum = 6;

            var actualResult = new Day3MaximumSubArray().GetMaximumSubArray(inputArray);
            actualResult.Should().Be(expectedSum);

            
        }
    }
}
