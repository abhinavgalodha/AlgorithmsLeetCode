﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Day2HappyNumber
    {
        /*
        Write an algorithm to determine if a number is "happy".

        A happy number is a number defined by the following process: Starting with any positive integer, replace the number by the sum of the squares of its digits, and repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1. Those numbers for which this process ends in 1 are happy numbers.

        Example: 

        Input: 19
        Output: true
        Explanation: 
        12 + 92 = 82
        82 + 22 = 68
        62 + 82 = 100
        12 + 02 + 02 = 1
   
         */

        private static readonly Dictionary<int, int> dictOfNumbers = new Dictionary<int, int>();
        private static List<int> listOfNumbers = new List<int>();
        private static List<int> listOfNumbersWithoutLinq = new List<int>();
        private static HashSet<int> hashSetOfNumbers = new HashSet<int>();

        public static bool FindHappyNumberUsingList(int numberToTest)
        {
            int sumOfSquaresOfDigits = 0;
            if (listOfNumbers.Contains(numberToTest))
            {
                return false;
            }
            listOfNumbers.Add(numberToTest);
            while (sumOfSquaresOfDigits != 1)
            {
                var arrayOfNumbers = new List<int>();
            
                var quotient = numberToTest;
                while (quotient !=  0)
                {
                    var remainder = quotient % 10;
                    arrayOfNumbers.Add(remainder);
                    quotient = quotient / 10;
                }

                sumOfSquaresOfDigits = arrayOfNumbers.Aggregate(0,(acc, start) => (int) (acc + Math.Pow(start,2)));
                if (sumOfSquaresOfDigits != 1)
                {
                    return FindHappyNumberUsingList(sumOfSquaresOfDigits);
                }
            }
            return true;
        }

        public static bool FindHappyNumberUsingDictionary(int numberToTest)
        {
            int sumOfSquaresOfDigits = 0;
            if (dictOfNumbers.ContainsKey(numberToTest))
            {
                return false;
            }
            dictOfNumbers.Add(numberToTest, 0);
            while (sumOfSquaresOfDigits != 1)
            {
                var arrayOfNumbers = new List<int>();
            
                var quotient = numberToTest;
                while (quotient !=  0)
                {
                    var remainder = quotient % 10;
                    arrayOfNumbers.Add(remainder);
                    quotient = quotient / 10;
                }

                sumOfSquaresOfDigits = arrayOfNumbers.Aggregate(0,(acc, start) => (int) (acc + Math.Pow(start,2)));
                if (sumOfSquaresOfDigits != 1)
                {
                    return FindHappyNumberUsingDictionary(sumOfSquaresOfDigits);
                }
            }
            return true;
        }

        public static bool FindHappyNumberUsingHashSet(int numberToTest)
        {
            int sumOfSquaresOfDigits = 0;
            if (hashSetOfNumbers.Contains(numberToTest))
            {
                return false;
            }
            hashSetOfNumbers.Add(numberToTest);
            while (sumOfSquaresOfDigits != 1)
            {
                var arrayOfNumbers = new List<int>();
            
                var quotient = numberToTest;
                while (quotient !=  0)
                {
                    var remainder = quotient % 10;
                    arrayOfNumbers.Add(remainder);
                    quotient = quotient / 10;
                }

                sumOfSquaresOfDigits = arrayOfNumbers.Aggregate(0,(acc, start) => (int) (acc + Math.Pow(start,2)));
                if (sumOfSquaresOfDigits != 1)
                {
                    return FindHappyNumberUsingHashSet(sumOfSquaresOfDigits);
                }
            }
            return true;
        }

        public static bool FindHappyNumberUsingListWithoutLinq(int numberToTest)
        {
            int sumOfSquaresOfDigits = 0;
            if (listOfNumbersWithoutLinq.Contains(numberToTest))
            {
                return false;
            }
            listOfNumbersWithoutLinq.Add(numberToTest);
            while (sumOfSquaresOfDigits != 1)
            {
                var quotient = numberToTest;
                while (quotient !=  0)
                {
                    var remainder = quotient % 10;
                    sumOfSquaresOfDigits += remainder * remainder;
                    quotient = quotient / 10;
                }

                if (sumOfSquaresOfDigits != 1)
                {
                    return FindHappyNumberUsingList(sumOfSquaresOfDigits);
                }
            }
            return true;
        }

        public static bool FindHappyNumberUsingHashSetWith2Pointers(int numberToTest)
        {
            int slowPointer = CalculateSquareOfDigits(numberToTest);
            int fastPointer = CalculateSquareOfDigits(CalculateSquareOfDigits(numberToTest));

            while (slowPointer != fastPointer)
            {
                return FindHappyNumberUsingHashSetWith2Pointers(slowPointer);
            }
            return true;
        }

        private static int CalculateSquareOfDigits(int digit)
        {
            int sumOfSquaresOfDigits = 0;
            while (digit !=  0)
            {
                var remainder = digit % 10;
                sumOfSquaresOfDigits += remainder * remainder;
                digit = digit / 10;
            }
            return sumOfSquaresOfDigits;
        }

    }
}
