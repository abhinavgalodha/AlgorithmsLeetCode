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
    public class Day6GroupAnagramBenchmark
    {
        public List<string[]> Input() // for multiple arguments it's an IEnumerable of array of objects (object[])
            => new List<string[]>
            { 
                new string[] {"eat", "tea", "tan", "ate", "nat", "bat"} ,
            };

        [Benchmark]
        [ArgumentsSource(nameof(Input))]
        public void GetGroupAnagrams(string[] inputStringArray)
        {
            new Day6GroupAnagrams().GetAnagramsGroup(inputStringArray);
        }

    }
}
