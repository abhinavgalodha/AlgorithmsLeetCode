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
            BenchmarkRunner.Run<Day4BenchmarkMoveZeroes>();
            Console.ReadLine();
        }

    }
}
