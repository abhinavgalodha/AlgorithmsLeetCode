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
    public class Day4BenchmarkMoveZeroes
    {
        public IEnumerable<int[]> Numbers() // for multiple arguments it's an IEnumerable of array of objects (object[])
        {
            yield return new int[] { 0,1,0,3,12 };
            yield return new int[] { 0,0,0 };
            yield return new int[] { 1,1,1,3,12 };
            yield return new int[] { 12,1,0,3,12 };
        }
        
        [Benchmark]
        [ArgumentsSource(nameof(Numbers))]
        public void MoveAllZeroesInPlaceNoAdditionalArray(int[] arrayOfNumbers)
        {
            new Day4MoveZeroes().MoveAllZeroesInPlaceNoAdditionalArray(arrayOfNumbers);
        }

        [Benchmark]
        [ArgumentsSource(nameof(Numbers))]
        public void MoveAllZeroesUsingAdditionalArray(int[] arrayOfNumbers)
        {
            new Day4MoveZeroes().MoveAllZeroesUsingAdditionalArray(arrayOfNumbers);
        }

        [Benchmark]
        [ArgumentsSource(nameof(Numbers))]
        public void MoveAllZeroesUsing2Pointers(int[] arrayOfNumbers)
        {
            new Day4MoveZeroes().MoveAllZeroesUsing2Pointers(arrayOfNumbers);
        }

    }
}
