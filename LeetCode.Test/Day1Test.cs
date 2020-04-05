using FluentAssertions;
using Xunit;

namespace LeetCode.Test
{
    public class Day1Test
    {
        [Fact]
        public void WhenMultipleNumberInArrayFindElement()
        {
            var array = new int[] {4, 1, 2, 1, 2};

            var elementOnlyOnce = Day1SingleNumber.FindElementThatAppearsOnceWhenAllOtherAppearsTwicev2(array);

            elementOnlyOnce.Should().Be(4);
        }
    }
}
