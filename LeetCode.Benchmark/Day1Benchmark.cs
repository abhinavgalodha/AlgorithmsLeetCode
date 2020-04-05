using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Benchmark
{
    [MemoryDiagnoser]
    public class Day1Benchmark
    {
        [Benchmark]
        public void WhenMultipleNumberInArrayFindElement()
        {
            /*
             |                               Method |     Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
             |------------------------------------- |---------:|---------:|---------:|-------:|------:|------:|----------:|
             | WhenMultipleNumberInArrayFindElement | 11.64 ns | 0.277 ns | 0.296 ns | 0.0115 |     - |     - |      48 B |
             */
            var array = new int[] {4, 1, 2, 1, 2};

            var elementOnlyOnce = Day1SingleNumber.FindElementThatAppearsOnceWhenAllOtherAppearsTwice(array);

        }

        [Benchmark]
        public void WhenMultipleNumberInArrayFindElementv1()
        {
            var array = new int[] {4, 1, 2, 1, 2};

            var elementOnlyOnce = Day1SingleNumber.FindElementThatAppearsOnceWhenAllOtherAppearsTwicev1(array);
        }

        [Benchmark]
        public void WhenMultipleNumberInArrayFindElementv2()
        {
            var array = new int[] {4, 1, 2, 1, 2};
            var elementOnlyOnce = Day1SingleNumber.FindElementThatAppearsOnceWhenAllOtherAppearsTwicev2(array);

        }
    }
}
