﻿using FluentAssertions;
using LeetCode.Test.Extension;
using LeetCode.Test.TestCollection;
using System.Collections.Generic;
using Xunit;

namespace LeetCode.Test
{
    public class ProductOfArrayExceptSelfTests
    {
        public static IEnumerable<object[]> TestData
            => new List<object[]>
               {
                    new object[] {new int[] {1,2,3,4} , new int[] {24,12,8,6} },
                    new object[] {new int[] {1,2,3,-4} , new int[] {-24,-12,-8,6} },
                    new object[] {new int[] {0,0} , new int[] {0,0} },
                    new object[] {new int[] {1,0} , new int[] {0,1} },
                    new object[] {new int[] {0,1,1} , new int[] {1,0,0} },
               };


        [Theory]
        [MemberData(nameof(TestData))]
        public void ProductArrayExceptSelfPositiveTest(int[] inputArray, int[] expectedArray)
        {
            var result = new ProductOfArrayExceptSelf().ProductExceptSelf(inputArray);
            result.Should().BeEquivalentWithStrictOrderTo(expectedArray);
        }
    }
}
