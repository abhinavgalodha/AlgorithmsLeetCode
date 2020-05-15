using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using LeetCode.Test.Extension;
using Xunit;

namespace LeetCode.Test
{
    public class JumpGameTests
    {
        public static IEnumerable<object[]> TestData
            => new List<object[]>
            {
                new object[] {new int[] {2,3,1,1,4} , true},
                new object[] {new int[] {3,2,1,0,4} , false},
                new object[] {new int[] {0,1} , false},
                new object[] {new int[] {0} , true},
                new object[] {new int[] {2,0,0} , true},
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void PositiveTests(int[] inputArray, bool canJump)
        {
            var result  = new JumpGame().CanJump(inputArray);
            result.Should().Be(canJump);
        }
    }
}
