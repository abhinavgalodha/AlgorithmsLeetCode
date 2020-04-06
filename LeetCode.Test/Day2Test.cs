using FluentAssertions;
using Xunit;

namespace LeetCode.Test
{
    public class Day2Test
    {
        [Theory]
        [InlineData(7)]
        [InlineData(10)]
        [InlineData(13)]
        [InlineData(19)]
        [InlineData(23)]
        [InlineData(86)]
        [InlineData(91)]
        [InlineData(94)]
        [InlineData(97)]
        public void WhenHappyNumberIsAvailableUsingDictionary(int number)
        {
            var elementOnlyOnce = new Day2HappyNumber().FindHappyNumberUsingDictionary(number);

            elementOnlyOnce.Should().BeTrue();
        }

        [Theory]
        [InlineData(7)]
        [InlineData(10)]
        [InlineData(13)]
        [InlineData(19)]
        [InlineData(23)]
        [InlineData(86)]
        [InlineData(91)]
        [InlineData(94)]
        [InlineData(97)]
        public void WhenHappyNumberIsAvailableUsingList(int number)
        {
            var elementOnlyOnce = new Day2HappyNumber().FindHappyNumberUsingList(number);

            elementOnlyOnce.Should().BeTrue();
        }

        [Theory]
        [InlineData(7)]
        [InlineData(10)]
        [InlineData(13)]
        [InlineData(19)]
        [InlineData(23)]
        [InlineData(86)]
        [InlineData(91)]
        [InlineData(94)]
        [InlineData(97)]
        public void WhenHappyNumberIsAvailableUsingHashSet(int number)
        {
            var elementOnlyOnce = new Day2HappyNumber().FindHappyNumberUsingHashSet(number);

            elementOnlyOnce.Should().BeTrue();
        }

        [Theory]
        [InlineData(7)]
        [InlineData(10)]
        [InlineData(13)]
        [InlineData(19)]
        [InlineData(23)]
        [InlineData(86)]
        [InlineData(91)]
        [InlineData(94)]
        [InlineData(97)]
        public void WhenHappyNumberIsUsingListWithoutLinq(int number)
        {
            var elementOnlyOnce = new Day2HappyNumber().FindHappyNumberUsingListWithoutLinq(number);

            elementOnlyOnce.Should().BeTrue();
        }

        //FindHappyNumberUsingHashSetWith2Pointers

        [Theory]
        [InlineData(1)]
        [InlineData(7)]
        [InlineData(10)]
        [InlineData(13)]
        [InlineData(19)]
        [InlineData(23)]
        [InlineData(86)]
        [InlineData(91)]
        [InlineData(94)]
        [InlineData(97)]
        public void WhenHappyNumberIsUsing2Pointers(int numberToTest)
        {
            var elementOnlyOnce = new Day2HappyNumber().FindHappyNumberUsingHashSetWith2Pointers(numberToTest);

            elementOnlyOnce.Should().BeTrue();
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        public void WhenNotHappyNumberIsUsing2Pointers(int numberToTest)
        {
            var elementOnlyOnce = new Day2HappyNumber().FindHappyNumberUsingHashSetWith2Pointers(numberToTest);

            elementOnlyOnce.Should().BeFalse();
        }
    }
}

