using FluentAssertions;
using Xunit;

namespace LeetCode.Test
{
    public class LRUCacheTests
    {
        [Fact]
        public void When1ItemIsInserted_ThenReturnTheItem()
        {
            LRUCache cache = new LRUCache( 2);
            cache.Put(1, 1);
            var actualValue = cache.Get(1);
            actualValue.Should().Be(1);
        }

        [Fact]
        public void When2ItemAreInserted_ThenVerifyBothHaveBeenInserted()
        {
            LRUCache cache = new LRUCache( 2);
            cache.Put(1, 1);
            cache.Put(2, 2);
            var firstValue = cache.Get(1);
            var secondValue = cache.Get(2);
            firstValue.Should().Be(1);
            secondValue.Should().Be(2);
        }

        [Fact]
        public void When1ItemInCacheAndGetKeyWhichDoesNotExist_ThenReturnMinus1()
        {
            LRUCache cache = new LRUCache( 2);
            cache.Put(1, 1);
            var actualValue = cache.Get(2);
            actualValue.Should().Be(-1);
        }

        [Fact]
        public void WhenCacheCapacityReached_ThenInvalidateLeastRecentlyUsedItemBeforeInsertingANewItem()
        {
            LRUCache cache = new LRUCache( 2);
            cache.Put(1, 1);
            cache.Put(2, 2);
            cache.Get(1);       // returns 1
            cache.Put(3, 3);    // evicts key 2
            cache.Get(2);       // returns -1 (not found)
            cache.Put(4, 4);    // evicts key 1
            var valueDoesNotExist = cache.Get(1);       // returns -1 (not found)
            var firstValue = cache.Get(3);       // returns 3
            var secondValue = cache.Get(4);       // returns 4

            valueDoesNotExist.Should().Be(-1);
            firstValue.Should().Be(3);
            secondValue.Should().Be(4);
        }

        [Fact]
        public void WhenSameKeyInsertedTwiceWithDifferentValue_ThenReturnLastValueForTheKey()
        {
            LRUCache cache = new LRUCache( 2);
            cache.Put(2, 1);
            cache.Put(2, 2);
            var result = cache.Get(2);
            result.Should().Be(2);
        }

        [Fact]
        public void WhenSomeRandomOperationLRUShouldWorkCorrectly()
        {
            LRUCache cache = new LRUCache( 2);
            cache.Get(2);
            cache.Put(2, 6);
            cache.Get(1);
            cache.Put(1, 5);
            cache.Put(1, 2);
            cache.Get(1);
            var result = cache.Get(2);
            result.Should().Be(6);
        }
    }
}
