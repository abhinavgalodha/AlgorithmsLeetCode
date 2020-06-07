using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Test
{
    public class CourseSchedule207Tests
    {
        public static IEnumerable<object[]> TestData
            => new List<object[]>
            {
                new object[] { 2, new int[][] { new int[] {1,0} }, true},
                new object[] { 2, new int[][] { new int[] {0,1}, new int[] {1,0} }, false},
                new object[] { 3, new int[][] { new int[] {0,1}, new int[] {0,2} , new int[] {1,2}}, true},
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void PositiveTests(int numCourses, int[][] prerequisites, bool expectedResult)
        {
            var result  = new CourseSchedule207().CanFinish(numCourses, prerequisites);
            result.Should().Be(expectedResult);
        }

    }
}
