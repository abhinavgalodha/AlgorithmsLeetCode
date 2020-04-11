using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace LeetCode.Benchmark
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class Day5BuyAndSellStockBenchmark
    {
        public IEnumerable<int[]> Numbers() // for multiple arguments it's an IEnumerable of array of objects (object[])
        {
            yield return new int[] { 7,6,4,3,1 };
            yield return new int[] { 1,1,1,3,12 };
            yield return new int[] { 1,2,3,4,5,2,4,4,6,7,9,9,9,9,9,10 };
        }
        
        [Benchmark]
        [ArgumentsSource(nameof(Numbers))]
        public void GetMaximumProfit(int[] arrayOfNumbers)
        {
            new Day5BuyAndSellStockWithMaxProfit().GetMaximumProfit(arrayOfNumbers);
        }

        [Benchmark]
        [ArgumentsSource(nameof(Numbers))]
        public void GetMaximumProfitSingleLoop(int[] arrayOfNumbers)
        {
            new Day5BuyAndSellStockWithMaxProfit().GetMaximumProfitSingleLoop(arrayOfNumbers);
        }
    }
}
