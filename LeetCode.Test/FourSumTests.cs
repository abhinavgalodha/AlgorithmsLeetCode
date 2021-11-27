﻿using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using LeetCode.Test.Extension;
using Xunit;

namespace LeetCode.Test
{
    public class FourSumTests
    {
        public static IEnumerable<object[]> TestData
            => new List<object[]>
            {
                new object[] {new int[] {1, 2} , new int[] {-2, -1}, new int[] {-1, 2}, new int[] {0,2}, 2 },
                new object[] {new int[] {0,1,-1} , new int[] {-1, 1, 0}, new int[] {0, 0, 1}, new int[] {-1,1,1}, 17 },
                new object[] {new int[] {-1,-1} , new int[] {-1, 1}, new int[] {-1, 1}, new int[] {1,-1}, 6 },
            };



        [Theory]
        [MemberData(nameof(TestData))]
        public void PositiveTests(int[] inputArray1, int[] inputArray2, int[] inputArray3, int[] inputArray4, int target)
        {
            var result  = new FourSum().FourSumCountUsingNaiveImplementation(inputArray1, inputArray2, inputArray3, inputArray4);
            result.Should().Be(target);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void PositiveTests1(int[] inputArray1, int[] inputArray2, int[] inputArray3, int[] inputArray4, int target)
        {
            var result  = new FourSum().FourSumCountUsingDictionaryWithCubicRuntime(inputArray1, inputArray2, inputArray3, inputArray4);
            result.Should().Be(target);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void PositiveTests2(int[] inputArray1, int[] inputArray2, int[] inputArray3, int[] inputArray4, int target)
        {
            var result  = new FourSum().FourSumCountUsingDictionaryWithQuadraticRunTime(inputArray1, inputArray2, inputArray3, inputArray4);
            result.Should().Be(target);
        }

        public static IEnumerable<object[]> TestData1
            => new List<object[]>
            {
                new object[] {new int[] {-175000000,-50000000,225000000,-225000000,125000000,-75000000,150000000,150000000,-200000000,100000000,75000000,-175000000,0,75000000,50000000,125000000,125000000,100000000,-175000000,-75000000,200000000,-50000000,125000000,-75000000,75000000,250000000,25000000,-125000000,25000000,-150000000,200000000,-175000000,100000000,0,-250000000,-75000000,150000000,-175000000,150000000,-250000000,-125000000,200000000,50000000,150000000,75000000,250000000,100000000,-225000000,-75000000,-75000000,100000000,-25000000,175000000,-225000000,-75000000,150000000,-225000000,-250000000,-125000000,125000000,-100000000,-250000000,200000000,-225000000,125000000,25000000,75000000,250000000,-225000000,150000000,-50000000,75000000,-125000000,25000000,-50000000,-75000000,-25000000,-175000000,-25000000,-75000000,100000000,-200000000,-100000000,200000000,50000000,-175000000,125000000,-100000000,-150000000,25000000,-175000000,125000000,-200000000,-125000000,-175000000,-25000000,250000000,-50000000,-225000000,150000000,-25000000,-75000000,50000000,175000000,-100000000,50000000,125000000,-25000000,-225000000,125000000,150000000,-100000000,-100000000,200000000,-200000000,-225000000,200000000,-125000000,150000000,25000000,-250000000,-225000000,250000000,250000000,200000000,200000000,-100000000,-150000000,-50000000,-50000000,175000000,125000000,75000000,250000000,-150000000,-50000000,-150000000,-100000000,100000000,0,75000000,-200000000,100000000,125000000,50000000,50000000,-25000000,-25000000,0,-150000000,-75000000,75000000,50000000,-225000000,-225000000,-250000000,-100000000,-100000000,-125000000,50000000,-75000000,-25000000,150000000,-250000000,-50000000,225000000,50000000,-75000000,-75000000,150000000,250000000,-50000000,25000000,-50000000,200000000,-50000000,-200000000,-200000000,-75000000,-150000000,200000000,-100000000,-100000000,250000000,-225000000,100000000,0,225000000,-100000000,125000000,-200000000,-225000000,225000000,-100000000,-25000000,25000000,-100000000,-125000000,100000000,-50000000,250000000,-50000000,225000000,-250000000,-50000000,-100000000,-200000000,-150000000,25000000,75000000,200000000,200000000,-25000000,-150000000,200000000,-175000000,200000000,-125000000,-75000000,-150000000,-225000000,0,-125000000,-100000000,-250000000,25000000,200000000,-75000000,50000000,-225000000,-100000000,-175000000,-25000000,-75000000,100000000,50000000,-150000000,-75000000,0,-250000000,50000000,50000000,75000000,150000000,-100000000,25000000,175000000,200000000,-25000000,-50000000,-175000000,-200000000,-125000000,-225000000,-100000000,125000000,250000000,-200000000,175000000,50000000,-25000000,-50000000,250000000,150000000,225000000,125000000,-150000000,75000000,-100000000,100000000,-100000000,-50000000,-125000000,-25000000,-50000000,-75000000,225000000,125000000,100000000,-250000000,50000000,-75000000,100000000,-225000000,-100000000,-25000000,0,-175000000,75000000,25000000,-25000000,-25000000,200000000,250000000,125000000,-250000000,175000000,-25000000,100000000,-25000000,-50000000,0,200000000,-125000000,75000000,-75000000,-100000000,50000000,-175000000,75000000,50000000,100000000,200000000,150000000,-250000000,150000000,-150000000,225000000,150000000,150000000,225000000,150000000,-150000000,0,250000000,225000000,-175000000,-250000000,225000000,-25000000,200000000,125000000,50000000,25000000,25000000,175000000,100000000,250000000,125000000,-25000000,-75000000,0,50000000,50000000,-250000000,75000000,250000000,-150000000,250000000,125000000,-100000000,225000000,-75000000,-250000000,125000000,50000000,-100000000,-75000000,-100000000,100000000,-125000000,75000000,-25000000,225000000,-225000000,225000000,175000000,-250000000,-125000000,-25000000,100000000,25000000,-25000000,-75000000,75000000,250000000,-250000000,175000000,-100000000,-75000000,50000000,225000000,-225000000,-100000000,25000000,-75000000,150000000,-250000000,-250000000,-225000000,-100000000,-175000000,50000000,-75000000,0,225000000,-25000000,200000000,-50000000,225000000,250000000,75000000,150000000,25000000,-25000000,-125000000,-150000000,75000000,250000000,-25000000,-225000000,75000000,100000000,-50000000,0,-100000000,-150000000,25000000,-125000000,200000000,-175000000,75000000,-50000000,-175000000,100000000,0,150000000,125000000,150000000,-200000000,-250000000,25000000,-125000000,-125000000,50000000,-250000000,-100000000,100000000,125000000,-50000000,-75000000,25000000,125000000,25000000,-250000000,250000000,-100000000,75000000,250000000,225000000,75000000,-200000000,-150000000,225000000,175000000,75000000,175000000,0,75000000,0,-100000000,-250000000,0,0,-75000000,175000000,25000000,-250000000,200000000,125000000,-75000000,-25000000,125000000,-225000000,175000000,-75000000,-225000000,50000000,75000000,-125000000,-225000000,0,-150000000,-75000000,125000000,-125000000,150000000,-25000000,-250000000,225000000,175000000,25000000,-100000000,75000000,175000000,-75000000,-75000000,-200000000,-75000000,100000000} , 
                    new int[] {-125000000,0,75000000,225000000,225000000,25000000,-200000000,100000000,175000000,175000000,50000000,-125000000,125000000,-125000000,250000000,250000000,-125000000,125000000,75000000,-200000000,-50000000,-225000000,100000000,150000000,225000000,150000000,75000000,100000000,-125000000,-100000000,-75000000,25000000,-125000000,-225000000,-175000000,-200000000,-175000000,225000000,150000000,-175000000,75000000,250000000,75000000,125000000,175000000,175000000,175000000,0,-50000000,-150000000,125000000,250000000,-225000000,-75000000,250000000,-225000000,150000000,-150000000,200000000,-75000000,-75000000,125000000,175000000,-100000000,-100000000,125000000,-250000000,200000000,-225000000,-200000000,25000000,50000000,175000000,25000000,-250000000,100000000,-50000000,125000000,-175000000,25000000,25000000,100000000,-75000000,225000000,150000000,200000000,150000000,-225000000,-50000000,175000000,150000000,-150000000,-225000000,75000000,-175000000,150000000,125000000,-250000000,225000000,-175000000,-150000000,0,-225000000,0,-50000000,-125000000,50000000,-150000000,-225000000,-125000000,200000000,225000000,200000000,200000000,-25000000,-175000000,175000000,-225000000,-50000000,-200000000,175000000,75000000,-100000000,50000000,-25000000,100000000,-100000000,-175000000,175000000,-150000000,-225000000,-125000000,-225000000,-200000000,125000000,-100000000,-175000000,100000000,150000000,-125000000,-225000000,75000000,250000000,50000000,-200000000,-150000000,-175000000,-250000000,250000000,50000000,-125000000,200000000,175000000,-150000000,-100000000,-225000000,150000000,-150000000,-25000000,-175000000,-225000000,-100000000,175000000,50000000,25000000,-50000000,-100000000,-100000000,125000000,200000000,50000000,-125000000,50000000,150000000,25000000,-250000000,-75000000,-50000000,125000000,-150000000,125000000,-175000000,-25000000,-200000000,225000000,75000000,-50000000,150000000,100000000,-150000000,225000000,50000000,-25000000,125000000,225000000,225000000,-100000000,100000000,-50000000,-200000000,175000000,25000000,0,-75000000,-25000000,200000000,100000000,0,175000000,-50000000,225000000,-250000000,50000000,200000000,-50000000,-175000000,-75000000,-100000000,-175000000,-175000000,175000000,25000000,25000000,200000000,-50000000,150000000,-125000000,-75000000,75000000,-50000000,-125000000,125000000,-50000000,225000000,25000000,100000000,0,-250000000,-150000000,100000000,-150000000,-175000000,225000000,-200000000,250000000,150000000,225000000,-25000000,-175000000,-25000000,200000000,75000000,100000000,175000000,125000000,-75000000,100000000,-100000000,-25000000,125000000,250000000,-100000000,-25000000,250000000,-75000000,200000000,200000000,125000000,200000000,-25000000,200000000,125000000,100000000,200000000,125000000,25000000,150000000,150000000,200000000,100000000,125000000,-50000000,-225000000,225000000,75000000,-100000000,25000000,200000000,50000000,0,-50000000,-25000000,-125000000,75000000,250000000,250000000,-150000000,100000000,-200000000,-125000000,0,-175000000,-25000000,25000000,-25000000,250000000,-100000000,-25000000,250000000,200000000,-225000000,200000000,0,0,125000000,-150000000,-150000000,-225000000,100000000,-200000000,-225000000,-250000000,-250000000,0,50000000,225000000,75000000,125000000,-250000000,25000000,25000000,250000000,125000000,75000000,-225000000,-150000000,125000000,100000000,-100000000,-75000000,175000000,200000000,-125000000,225000000,100000000,-75000000,-25000000,225000000,-100000000,-50000000,25000000,-125000000,-175000000,-100000000,-150000000,225000000,-25000000,25000000,-100000000,-150000000,175000000,-100000000,50000000,50000000,225000000,125000000,-175000000,150000000,150000000,150000000,-200000000,-175000000,-150000000,25000000,150000000,-75000000,100000000,100000000,-200000000,250000000,225000000,-125000000,-250000000,125000000,-150000000,-150000000,-225000000,-250000000,125000000,0,250000000,-125000000,-125000000,200000000,25000000,50000000,-50000000,200000000,-100000000,250000000,125000000,150000000,-100000000,-150000000,100000000,100000000,175000000,100000000,-100000000,125000000,225000000,200000000,225000000,0,-150000000,150000000,225000000,-150000000,75000000,75000000,-125000000,-50000000,250000000,-175000000,175000000,0,250000000,250000000,0,50000000,-125000000,125000000,-100000000,-125000000,-225000000,-50000000,100000000,100000000,250000000,0,50000000,175000000,175000000,175000000,-125000000,50000000,-200000000,200000000,-200000000,100000000,25000000,-175000000,-200000000,-125000000,-200000000,-150000000,0,25000000,225000000,200000000,-200000000,250000000,-200000000,-225000000,-150000000,125000000,25000000,250000000,125000000,-250000000,-250000000,200000000,-200000000,-225000000,-75000000,225000000,-125000000,75000000,225000000,150000000,50000000,-150000000,250000000,125000000,125000000,200000000,-250000000,225000000,-200000000,125000000,200000000,200000000,225000000,-50000000,50000000,250000000,125000000,100000000,75000000,-225000000},
                    new int[] {-100000000,-175000000,-75000000,25000000,200000000,100000000,-125000000,125000000,-125000000,-175000000,-150000000,25000000,225000000,225000000,75000000,125000000,250000000,100000000,-200000000,-175000000,-250000000,50000000,-150000000,-250000000,25000000,175000000,-225000000,100000000,-225000000,250000000,225000000,-75000000,125000000,-250000000,-150000000,200000000,-225000000,-75000000,100000000,-100000000,-125000000,-50000000,-225000000,-100000000,50000000,-175000000,225000000,175000000,-125000000,250000000,75000000,-225000000,-125000000,-75000000,225000000,125000000,-225000000,150000000,150000000,200000000,50000000,25000000,0,225000000,-200000000,-175000000,-50000000,175000000,150000000,-125000000,-250000000,-125000000,-150000000,225000000,-225000000,175000000,-225000000,150000000,-200000000,150000000,-125000000,225000000,-225000000,75000000,-200000000,-100000000,-250000000,-125000000,50000000,250000000,-150000000,-250000000,-100000000,-25000000,-100000000,75000000,75000000,175000000,250000000,-75000000,-50000000,175000000,0,-125000000,250000000,-175000000,-50000000,-100000000,-175000000,-75000000,-125000000,-100000000,250000000,-225000000,-250000000,200000000,-250000000,100000000,200000000,250000000,-75000000,225000000,75000000,-75000000,-250000000,-125000000,175000000,175000000,-175000000,25000000,100000000,-75000000,200000000,-200000000,-175000000,150000000,25000000,50000000,50000000,0,175000000,-200000000,-25000000,150000000,100000000,250000000,-25000000,-125000000,0,0,-75000000,175000000,-100000000,-25000000,-175000000,75000000,-175000000,125000000,150000000,-250000000,-50000000,-25000000,125000000,250000000,-200000000,250000000,-225000000,175000000,100000000,-100000000,-150000000,25000000,-225000000,250000000,75000000,-75000000,-100000000,-50000000,150000000,250000000,175000000,-25000000,175000000,-175000000,250000000,-50000000,-150000000,-200000000,-175000000,200000000,-225000000,-25000000,-25000000,-50000000,150000000,25000000,75000000,-200000000,-100000000,-200000000,-75000000,-125000000,150000000,-50000000,-175000000,250000000,25000000,100000000,200000000,-200000000,200000000,-175000000,75000000,-100000000,-100000000,-50000000,-150000000,25000000,250000000,0,-50000000,150000000,-175000000,-150000000,-250000000,-250000000,250000000,100000000,150000000,-175000000,200000000,125000000,225000000,50000000,-175000000,50000000,-25000000,-100000000,100000000,225000000,125000000,-200000000,25000000,-150000000,50000000,200000000,225000000,-75000000,-225000000,250000000,-250000000,-125000000,150000000,150000000,200000000,-50000000,0,-75000000,100000000,25000000,-175000000,0,-200000000,-25000000,125000000,100000000,0,-200000000,-75000000,-125000000,-75000000,125000000,125000000,200000000,-50000000,-100000000,25000000,-200000000,250000000,-100000000,-50000000,-25000000,-150000000,-150000000,50000000,-175000000,25000000,-150000000,-125000000,175000000,-125000000,100000000,-175000000,-100000000,-25000000,200000000,100000000,75000000,0,50000000,-150000000,-25000000,-75000000,50000000,225000000,-75000000,100000000,125000000,-200000000,-225000000,75000000,125000000,-150000000,250000000,-225000000,-25000000,125000000,-50000000,75000000,-100000000,225000000,-125000000,125000000,250000000,-125000000,-50000000,-250000000,-200000000,125000000,75000000,-25000000,-200000000,-175000000,-225000000,-75000000,200000000,-150000000,50000000,150000000,25000000,-150000000,-250000000,-250000000,200000000,250000000,125000000,-75000000,200000000,-175000000,-75000000,175000000,-225000000,25000000,25000000,0,-175000000,125000000,-50000000,-150000000,-25000000,75000000,50000000,-150000000,250000000,-75000000,-25000000,100000000,100000000,-225000000,25000000,200000000,175000000,250000000,-100000000,50000000,-25000000,200000000,-75000000,75000000,25000000,25000000,25000000,150000000,-150000000,-200000000,0,-175000000,100000000,75000000,150000000,125000000,175000000,175000000,-50000000,150000000,0,-125000000,150000000,175000000,175000000,-75000000,250000000,250000000,-100000000,-225000000,-200000000,-200000000,150000000,-175000000,250000000,175000000,-50000000,-100000000,-50000000,150000000,200000000,-175000000,75000000,75000000,100000000,125000000,-50000000,-100000000,-50000000,-50000000,200000000,175000000,-175000000,-150000000,175000000,-100000000,25000000,25000000,225000000,-225000000,50000000,200000000,125000000,250000000,-25000000,150000000,-150000000,-175000000,50000000,-125000000,-200000000,150000000,200000000,225000000,250000000,-125000000,225000000,0,225000000,25000000,-250000000,100000000,225000000,0,225000000,-100000000,-75000000,-50000000,-200000000,25000000,-125000000,-200000000,-175000000,100000000,100000000,-75000000,250000000,-150000000,-75000000,-25000000,175000000,0,250000000,50000000,100000000,25000000,-150000000,175000000,-175000000,200000000,150000000,200000000,-100000000,-25000000,125000000,-250000000,125000000,-225000000,-225000000,175000000,-225000000,75000000,-200000000,-100000000,-75000000}, 
                    new int[] {150000000,150000000,-75000000,-100000000,50000000,150000000,0,175000000,25000000,-25000000,225000000,250000000,225000000,-250000000,-25000000,250000000,-75000000,-150000000,100000000,50000000,-25000000,75000000,-225000000,-250000000,-25000000,50000000,25000000,-225000000,-25000000,-150000000,-250000000,225000000,-175000000,0,25000000,200000000,200000000,200000000,50000000,0,-50000000,200000000,25000000,200000000,-150000000,-150000000,200000000,-150000000,125000000,-225000000,-200000000,100000000,-175000000,-100000000,-225000000,0,0,100000000,-100000000,0,200000000,-250000000,0,-250000000,-125000000,-150000000,0,150000000,-100000000,225000000,-225000000,-175000000,-100000000,-50000000,-225000000,-100000000,-50000000,175000000,-200000000,-200000000,-150000000,225000000,-225000000,0,0,-200000000,125000000,25000000,175000000,-200000000,75000000,75000000,250000000,-150000000,225000000,-250000000,-225000000,25000000,-100000000,175000000,-200000000,50000000,-150000000,-175000000,-225000000,100000000,250000000,-150000000,-75000000,-25000000,-225000000,225000000,-125000000,-175000000,75000000,-50000000,50000000,200000000,-50000000,200000000,-25000000,-200000000,-75000000,200000000,75000000,25000000,-225000000,0,75000000,-175000000,50000000,25000000,-25000000,-225000000,-200000000,175000000,-225000000,-225000000,-100000000,75000000,-125000000,75000000,100000000,125000000,-150000000,-150000000,-250000000,175000000,-50000000,150000000,-125000000,125000000,100000000,50000000,0,0,-125000000,-75000000,25000000,-175000000,150000000,50000000,125000000,-250000000,125000000,-250000000,250000000,225000000,-200000000,-75000000,50000000,175000000,-100000000,-125000000,-150000000,150000000,-250000000,-75000000,100000000,150000000,25000000,-250000000,225000000,100000000,200000000,100000000,-100000000,0,-175000000,25000000,-125000000,50000000,150000000,-100000000,225000000,-175000000,150000000,-100000000,100000000,125000000,75000000,225000000,125000000,-100000000,-75000000,-175000000,-225000000,-200000000,-50000000,150000000,150000000,100000000,75000000,150000000,125000000,-150000000,125000000,-125000000,-175000000,50000000,250000000,-50000000,-75000000,-250000000,-50000000,-125000000,-225000000,-50000000,50000000,-225000000,200000000,-75000000,225000000,100000000,-250000000,225000000,-25000000,-100000000,0,150000000,175000000,-175000000,225000000,-200000000,-100000000,-250000000,0,250000000,225000000,150000000,-175000000,-25000000,-200000000,-225000000,200000000,-50000000,225000000,250000000,-125000000,100000000,200000000,-200000000,-50000000,200000000,-150000000,-175000000,125000000,150000000,200000000,225000000,-100000000,200000000,-150000000,-175000000,0,100000000,-200000000,200000000,-50000000,-50000000,50000000,75000000,200000000,-150000000,100000000,-75000000,100000000,-250000000,225000000,225000000,-125000000,0,25000000,200000000,-150000000,-75000000,-100000000,25000000,-175000000,25000000,100000000,25000000,225000000,-75000000,100000000,-25000000,-150000000,-250000000,-75000000,100000000,-125000000,75000000,225000000,0,25000000,150000000,-75000000,-100000000,100000000,0,-100000000,100000000,150000000,200000000,-50000000,175000000,150000000,-225000000,50000000,-225000000,200000000,-100000000,-150000000,125000000,150000000,-125000000,0,225000000,-50000000,-125000000,25000000,150000000,-175000000,-125000000,-250000000,250000000,125000000,-75000000,-75000000,150000000,50000000,-250000000,-150000000,200000000,75000000,100000000,-175000000,125000000,25000000,-225000000,50000000,50000000,175000000,-25000000,-75000000,-150000000,25000000,0,-75000000,200000000,-225000000,200000000,-25000000,0,100000000,75000000,175000000,75000000,-150000000,0,-75000000,-100000000,-75000000,-250000000,250000000,50000000,-125000000,-250000000,150000000,-125000000,-225000000,75000000,-100000000,-25000000,-125000000,75000000,-75000000,25000000,-225000000,-125000000,-225000000,50000000,-225000000,-250000000,125000000,250000000,-150000000,-250000000,250000000,-50000000,100000000,-75000000,-200000000,50000000,50000000,-225000000,100000000,-125000000,-75000000,-200000000,150000000,-125000000,-25000000,-75000000,225000000,0,-225000000,-225000000,175000000,-25000000,50000000,-125000000,-175000000,150000000,-225000000,-100000000,50000000,200000000,175000000,-100000000,-125000000,-25000000,-175000000,-75000000,-75000000,175000000,100000000,175000000,-125000000,100000000,100000000,200000000,250000000,-100000000,-150000000,100000000,-75000000,-250000000,150000000,200000000,-125000000,-200000000,-100000000,175000000,125000000,-25000000,150000000,50000000,-25000000,25000000,-200000000,125000000,50000000,-75000000,250000000,-100000000,-175000000,-175000000,-50000000,-150000000,-150000000,-25000000,-250000000,200000000,-25000000,75000000,-175000000,200000000,225000000,175000000,-225000000,-50000000,-25000000,125000000,-100000000,75000000,25000000,75000000,225000000,250000000}, 
                    2 },
                new object[] {new int[] {0,1,-1} , new int[] {-1, 1, 0}, new int[] {0, 0, 1}, new int[] {-1,1,1}, 17 },
            };

    }
}