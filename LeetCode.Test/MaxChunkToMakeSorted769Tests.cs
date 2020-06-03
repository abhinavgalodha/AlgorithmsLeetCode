using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Xunit;

namespace LeetCode.Test
{
    public class MaxChunkToMakeSorted769Tests
    {
        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                new object[]{ new int[] {1,0,2,3,4}, 4 },
                new object[]{ new int[] {4,3,2,1,0}, 1 },
                new object[]{ new int[] {4,3,2,6,5}, 2 },
                new object[]{ new int[] {1,2,3,4}, 4 },
                new object[]{ new int[] {1}, 1 },
                new object[]{ new int[] {0,1}, 2 },
                new object[]{ new int[] {1,2,0,3}, 2 },
                new object[]{ new int[] {0,2,1}, 2 },
                new object[]{ new int[] {0,1,3,2}, 3 },
                new object[]{ new int[] {0,4,5,2,1,3}, 2 },
            };


        [Theory]
        [MemberData(nameof(TestData))]
        public void PositiveTests(int[] inputArray, int expectedPartitions)
        {
            var actualResult = new MaxChunksToMakeSorted769().MaxChunksToSorted(inputArray);
            actualResult.Should().Be(expectedPartitions);
        }
    }
}

