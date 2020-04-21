using FluentAssertions;
using System;
using Xunit;
[assembly: CollectionBehavior(MaxParallelThreads = 4)]

namespace LeetCode.Test.TestCollection
{
    public class GlobalSetupFixture
    {
        public GlobalSetupFixture()
        {
            Console.WriteLine("Global Set up for tests");
        }
    }

    [CollectionDefinition(nameof(GlobalSetupFixture))]
    public class GlobalSetupCollection : ICollectionFixture<GlobalSetupFixture>
    {

    }
}
