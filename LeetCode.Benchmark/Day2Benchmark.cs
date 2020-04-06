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
    public class Day2Benchmark
    {
        //[Params(1, 7, 10, 13, 19, 23, 28, 31, 32, 44, 49, 68, 70,79, 82, 86, 91, 94, 97)]
        [Params(19)]
        public int NumberToTest { get; set;}

        [Benchmark]
        public void FindHappyNumberUsingList()
        {
            var isHappyNumber = new Day2HappyNumber().FindHappyNumberUsingList(NumberToTest);
        }

        [Benchmark]
        public void FindHappyNumberUsingDictionary()
        {
            var isHappyNumber = new Day2HappyNumber().FindHappyNumberUsingDictionary(NumberToTest);
        }

        [Benchmark]
        public void FindHappyNumberUsingHashSet()
        {
            var isHappyNumber = new Day2HappyNumber().FindHappyNumberUsingHashSet(NumberToTest);
        }


        [Benchmark]
        public void FindHappyNumberUsingListWithoutLinq()
        {
            var isHappyNumber = new Day2HappyNumber().FindHappyNumberUsingListWithoutLinq(NumberToTest);
        }

        [Benchmark]
        public void FindHappyNumberUsing2Pointers()
        {
            var isHappyNumber = new Day2HappyNumber().FindHappyNumberUsingHashSetWith2Pointers(NumberToTest);
        }
    }
}
