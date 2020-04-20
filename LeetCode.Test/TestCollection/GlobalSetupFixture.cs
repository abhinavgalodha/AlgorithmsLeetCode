using FluentAssertions;
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

    [CollectionDefinition("GlobalSetup")]
    public class GlobalSetupCollection : ICollectionFixture<GlobalSetupFixture>
    {

    }
}
