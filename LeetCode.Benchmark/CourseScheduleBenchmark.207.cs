using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using FluentAssertions;

namespace LeetCode.Benchmark
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class CourseScheduleBenchmark207
    {
        public static IEnumerable<object[]> TestData
            => new List<object[]>
            {
                new object[] { 2, new int[][] { new int[] {1,0} }, true},
                new object[] { 2, new int[][] { new int[] {0,1}, new int[] {1,0} }, false},
                new object[] { 3, new int[][] { new int[] {0,1}, new int[] {0,2} , new int[] {1,2}}, true},
                new object[] { 4, new int[][] { new int[] {0,1}, new int[] {1,2} , new int[] {0,3}, new int[] {3,0}}, false},
            };

        
        [Benchmark]
        [ArgumentsSource(nameof(TestData))]
        public void PositiveTests(int numCourses, int[][] prerequisites, bool expectedResult)
        {
            var result  = new CourseSchedule207().CanFinish(numCourses, prerequisites);
        }

        /*
         Benchmark tests
         * |        Method | numCourses |    prerequisites | expectedResult |     Mean |    Error |   StdDev |   Median | Rank |  Gen 0 | Gen 1 | Gen 2 | Allocated |
           |-------------- |----------- |----------------- |--------------- |---------:|---------:|---------:|---------:|-----:|-------:|------:|------:|----------:|
           | PositiveTests |          2 | System.Int32[][] |           True | 293.1 ns | 18.67 ns | 55.04 ns | 300.6 ns |    1 | 0.0896 |     - |     - |     376 B |
           | PositiveTests |          2 | System.Int32[][] |          False | 325.8 ns | 18.64 ns | 54.95 ns | 348.2 ns |    2 | 0.0896 |     - |     - |     376 B |
           | PositiveTests |          3 | System.Int32[][] |           True | 417.3 ns | 21.20 ns | 62.52 ns | 421.9 ns |    3 | 0.1068 |     - |     - |     448 B |
           | PositiveTests |          4 | System.Int32[][] |          False | 498.8 ns | 18.41 ns | 54.29 ns | 506.2 ns |    4 | 0.1183 |     - |     - |     496 B |
         *
         *
         */
    }
}
