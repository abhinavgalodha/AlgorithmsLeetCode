using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Test
{
    public class Day5BuyAndSellStocksWithMaxProfitTests
    {
        public static IEnumerable<object[]> TestData
            => new List<object[]>
            {
                new object[] {new int[] {7,1,5,3,6,4} , 7 },
                new object[] {new int[] {1,2,3,4,5} , 4 },
                new object[] {new int[] {7,6,4,3,1} , 0 },
                new object[] {new int[] {4,50,60, 12,2,10} , 64 },
                new object[] {new int[] {7,6,4,3,1} , 0 },
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void GetMaximumProfitTests(int[] inputArray, int maximumProfit)
        {
            var actualProfit  = new Day5BuyAndSellStockWithMaxProfit().GetMaximumProfit(inputArray);
            actualProfit.Should().Be(maximumProfit);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void GetMaximumProfitTestsUsingSingleLoop(int[] inputArray, int maximumProfit)
        {
            var actualProfit  = new Day5BuyAndSellStockWithMaxProfit().GetMaximumProfitSingleLoop(inputArray);
            actualProfit.Should().Be(maximumProfit);
        }

    }
}
