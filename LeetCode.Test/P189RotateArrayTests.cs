using FluentAssertions;
using LeetCode.Test.Extension;
using System.Collections.Generic;
using Xunit;

namespace LeetCode.Test
{
    public class P189RotateArrayTests
    {
        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                new object[]{ new [] {1,2,3,4,5,6,7} , 3 , new [] {5,6,7,1,2,3,4}},
                new object[]{ new [] {-1,-100,3,99} , 2, new[] { 3,99,-1,-100 }},
                new object[]{ new [] {1} , 1, new[] { 1 }},
                new object[]{ new [] {1} , 2, new[] { 1 }},
                new object[]{ new [] {1,2} , 2, new[] { 1,2 }},
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void PositiveTests(int[] inputArray, int stepsToRotate, int[] expectedArray)
        {
            new P189RotateArray().Rotate(inputArray, stepsToRotate);
            inputArray.Should().BeEquivalentWithStrictOrderTo(expectedArray);
        }
    }
}
