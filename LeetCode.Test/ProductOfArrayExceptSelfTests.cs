using FluentAssertions;
using LeetCode.Test.TestCollection;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Test
{
    [Collection(nameof(GlobalSetupFixture))]
    public class ProductOfArrayExceptSelfTests
    {
        public static IEnumerable<object[]> TestData
            => new List<object[]>
               {
                    //new object[] {new int[] {1,2,3,4} , new int[] {24,12,8,6} },
                    //new object[] {new int[] {1,2,3,-4} , new int[] {-24,-12,-8,6} },
                    //new object[] {new int[] {0,0} , new int[] {0,0} },
                    new object[] {new int[] {1,0} , new int[] {0,1} },
                    //new object[] {new int[] {0,1,1} , new int[] {1,0,0} },
               };


        public ProductOfArrayExceptSelfTests(GlobalSetupFixture globalFixture)
        {

        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void ProductArrayExceptSelfPositiveTest(int[] inputArray, int[] expectedArray)
        {
            var result = new ProductOfArrayExceptSelf().ProductExceptSelf(inputArray);
            result.Should().BeEquivalentTo(expectedArray, options=> options.WithoutStrictOrdering());
        }

        [Fact]
        public void TestFluentAssertion()
        { 
            var firstArray = new int[] { 1,2,3};
            var secondArray = new int[] { 3,2,1};
            firstArray.Should().BeEquivalentTo(secondArray);
            //firstArray.Should().BeEquivalentTo(secondArray, options=> options.WithoutStrictOrdering());
        }
    }
}
