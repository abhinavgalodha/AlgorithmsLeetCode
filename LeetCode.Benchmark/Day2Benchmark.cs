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
        [Benchmark]
        public void FindHappyNumberUsingList()
        {
            var numberToTest = 19;
            var isHappyNumber = Day2HappyNumber.FindHappyNumberUsingList(numberToTest);

        }

        [Benchmark]
        public void FindHappyNumberUsingDictionary()
        {
            var numberToTest = 19;
            var isHappyNumber = Day2HappyNumber.FindHappyNumberUsingDictionary(numberToTest);
        }

        [Benchmark]
        public void FindHappyNumberUsingHashSet()
        {
            var numberToTest = 19;
            var isHappyNumber = Day2HappyNumber.FindHappyNumberUsingHashSet(numberToTest);
        }


        [Benchmark]
        public void FindHappyNumberUsingListWithoutLinq()
        {
            var numberToTest = 19;
            var isHappyNumber = Day2HappyNumber.FindHappyNumberUsingListWithoutLinq(numberToTest);
        }

        [Benchmark]
        public void FindHappyNumberUsing2Pointers()
        {
            var numberToTest = 19;
            var isHappyNumber = Day2HappyNumber.FindHappyNumberUsingHashSetWith2Pointers(numberToTest);
        }
    }
}
