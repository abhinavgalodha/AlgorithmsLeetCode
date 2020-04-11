using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace LeetCode.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BenchmarkRunner.Run<Day6GroupAnagramBenchmark>();
            Console.ReadLine();
        }

    }
}
