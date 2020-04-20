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
            AssertionOptions.AssertEquivalencyUsing(options => options.WithStrictOrdering());
        }
    }

    [CollectionDefinition(nameof(GlobalSetupFixture))]
    public class GlobalSetupCollection : ICollectionFixture<GlobalSetupFixture>
    {

    }
}
