using System;

namespace LeetCode.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] {4, 1, 2, 1, 2};
            var result = Day1SingleNumber.FindElementThatAppearsOnceWhenAllOtherAppearsTwice(array);
            result = Day1SingleNumber.FindElementThatAppearsOnceWhenAllOtherAppearsTwicev1(array);
            result = Day1SingleNumber.FindElementThatAppearsOnceWhenAllOtherAppearsTwicev2(array);

            if (result == 4)
            {
                System.Console.WriteLine("Find Element is Working fine.");
            }

            new Day2HappyNumber().FindHappyNumberUsingList(19);
            new Day2HappyNumber().FindHappyNumberUsingDictionary(19);
            new Day2HappyNumber().FindHappyNumberUsingHashSet(19);
            new Day2HappyNumber().FindHappyNumberUsingListWithoutLinq(19);

            System.Console.WriteLine("Hello World!");
        }
    }
}
