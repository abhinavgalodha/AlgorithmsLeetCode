using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Test
{

    [CollectionDefinition("GlobalSetup")]
    public class Day4MoveZeroesTests
    {
        public static IEnumerable<object[]> TestData
            => new List<object[]>
            {
                new object[] {new int[5] { 0,1,0,3,12 } , new int[5] { 1,3,12,0,0 } },
                new object[] {new int[3] { 0,0,0 } , new int[3] { 0,0,0 } },
                new object[] {new int[5] { 1,1,1,3,12 } , new int[5] { 1,1,1,3,12} },
                new object[] {new int[5] { 12,1,0,3,12 } , new int[5] { 12,1,3,12,0 } },
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void MoveAllZeroesInPlaceNoAdditionalArray(int[] inputArray, int[] expectedArray)
        {
            new Day4MoveZeroes().MoveAllZeroesInPlaceNoAdditionalArray(inputArray);
            inputArray.Should().BeEquivalentTo(expectedArray);
        }


        [Theory]
        [MemberData(nameof(TestData))]
        public void MoveAllZeroesUsingAdditionalArray(int[] inputArray, int[] expectedArray)
        {
            new Day4MoveZeroes().MoveAllZeroesUsingAdditionalArray(inputArray);
            inputArray.Should().BeEquivalentTo(expectedArray);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void MoveAllZeroesUsing2Pointers(int[] inputArray, int[] expectedArray)
        {
            new Day4MoveZeroes().MoveAllZeroesUsing2Pointers(inputArray);
            inputArray.Should().BeEquivalentTo(expectedArray);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void MoveAllZeroesUsing2PointersOptimal(int[] inputArray, int[] expectedArray)
        {
            new Day4MoveZeroes().MoveAllZeroesUsing2PointersOptimal(inputArray);
            inputArray.Should().BeEquivalentTo(expectedArray);
        }

    }
}
