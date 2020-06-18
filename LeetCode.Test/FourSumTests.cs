using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using LeetCode.Test.Extension;
using Xunit;

namespace LeetCode.Test
{
    public class FourSumTests
    {
        public static IEnumerable<object[]> TestData
            => new List<object[]>
            {
                new object[] {new int[] {1, 2} , new int[] {-2, -1}, new int[] {-1, 2}, new int[] {0,2}, 2 },
                new object[] {new int[] {0,1,-1} , new int[] {-1, 1, 0}, new int[] {0, 0, 1}, new int[] {-1,1,1}, 17 },
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void PositiveTests(int[] inputArray1, int[] inputArray2, int[] inputArray3, int[] inputArray4, int target)
        {
            var result  = new FourSum().FourSumCountUsingNaiveImplementation(inputArray1, inputArray2, inputArray3, inputArray4);
            result.Should().Be(target);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void PositiveTests1(int[] inputArray1, int[] inputArray2, int[] inputArray3, int[] inputArray4, int target)
        {
            var result  = new FourSum().FourSumCountUsingOptimization1(inputArray1, inputArray2, inputArray3, inputArray4);
            result.Should().Be(target);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void PositiveTests2(int[] inputArray1, int[] inputArray2, int[] inputArray3, int[] inputArray4, int target)
        {
            var result  = new FourSum().FourSumCountUsingHashSet(inputArray1, inputArray2, inputArray3, inputArray4);
            result.Should().Be(target);
        }
    }
}
