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
    public class Day3Benchmark
    {
        public IEnumerable<int[]> Numbers() // for multiple arguments it's an IEnumerable of array of objects (object[])
        {
            yield return new int[] { -2,1,-3,4,-1,2,1,-5,4 };
            yield return new int[] { -2,1 };
            yield return new int[] { -1,0,-2  };
        }
        
        [Benchmark]
        [ArgumentsSource(nameof(Numbers))]
        public void MaximumSubArrayUsingBruteForceQuadratic(int[] arrayOfNumbers)
        {
            var isHappyNumber = new Day3MaximumSubArray().GetMaximumSubArray(arrayOfNumbers);
        }

        [Benchmark]
        [ArgumentsSource(nameof(Numbers))]
        public void MaximumSubArrayUsingDp(int[] arrayOfNumbers)
        {
            var isHappyNumber = new Day3MaximumSubArray().GetMaximumSubArrayUsingDp(arrayOfNumbers);
        }

        [Benchmark]
        [ArgumentsSource(nameof(Numbers))]
        public void MaximumSubArrayUsingDp1(int[] arrayOfNumbers)
        {
            var isHappyNumber = new Day3MaximumSubArray().GetMaximumSubArrayUsingDp1(arrayOfNumbers);
        }

    }
}
