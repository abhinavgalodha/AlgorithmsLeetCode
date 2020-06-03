using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /*
    Link : https://leetcode.com/problems/max-chunks-to-make-sorted/
    Given an array arr that is a permutation of [0, 1, ..., arr.length - 1], we split the array into some number of "chunks" (partitions), and individually sort each chunk.  After concatenating them, the result equals the sorted array.

    What is the most number of chunks we could have made?

    Example 1:

    Input: arr = [4,3,2,1,0]
    Output: 1
    Explanation:
    Splitting into two or more chunks will not return the required result.
    For example, splitting into [4, 3], [2, 1, 0] will result in [3, 4, 0, 1, 2], which isn't sorted.

    Example 2:

    Input: arr = [1,0,2,3,4]
    Output: 4
    Explanation:
    We can split into two chunks, such as [1, 0], [2, 3, 4].
    However, splitting into [1, 0], [2], [3], [4] is the highest number of chunks possible.

    Note:

    arr will have length in range [1, 10].
    arr[i] will be a permutation of [0, 1, ..., arr.length - 1].

    */


    /*
     *  My Initial thoughts
     * Ex :[4,3,2,6,5]
       
        1. Calculate length of array  
        1.a. Set #TotalNumOfPartitions = 1
        2. Set Max # of partitions = Length of the Array - 1, which is maximum no. of partitions possible
        3. Iterate over the Array, i = 0; i < length ; i++
        3.a. Keep track of the biggest element of the Partition as it is used to check for the sorting order. LargestElement = array[0];
        4. Compare element of the first Partition with the element of the next partition
           if (firstPartitionElement < secondPartitionElement) // Elements in sorted order
            {
                4.a. 
                We have found our partition, #TotalNumOfPartitions += 1
            }
            else
            {
                Bigger element is first element and we don't have the partition
                LargestElement = firstPartitionElement
                4.b.
            }
        5. Return #TotalNumOfPartitions, if #TotalNumOfPartitions == Length, then return Length -1;
        
            Example 1 
       I/P Array = [1,2,3,4]
       
       Length = 4
       Max Partitions = 4 -1= 3
       
       1<2, totalPartition = 1
       2<3, totalPartition = 2
       3<4, totalPartition = 3
       
       Example 2
       I/P Array = [4,3,2,6,5]
       Length = 5
       Max Partitions = 5 - 1= 4
       
       4<3, Largest = 4
       4<2, Largest = 4
       4 < 6, totalPartition = 2
       6 < 5, Largest = 6
       
       
       Example 3
       I/P Array = [4,3,2,1,0]
       Length = 5
       Max Partitions = 5 - 1= 4
       
       4<3, Largest = 4
       4<2, Largest = 4
       4<1, Largest = 4
       4<0, Largest = 4
       totalPartition = 1
       
       
       Example 4
       I/P Array = [1,0,2,3,4]
       Length = 5
       Max Partitions = 5 - 1= 4
       
       1<0, Largest = 1
       1<2, totalPartition = 2
       2<3, totalPartition = 3
       3<4, totalPartition = 4
       
       
       
     */

    /*
     *  How to solve?
     *  1. Invariant for the permutation is given, Therefore no duplicates
     */
    public class MaxChunksToMakeSorted769
    {
        public int MaxChunksToSorted(int[] arr)
        {
            var numberOfPartitions = 1;
            var largestElementInPartition = arr[0];
            var previousLargestElementInPartition = arr[0];

            for (int index = 1; index < arr.Length; index++)
            {
                var nextElementInPartition = arr[index];

                if (largestElementInPartition < nextElementInPartition)
                {
                    previousLargestElementInPartition = largestElementInPartition;
                    largestElementInPartition = nextElementInPartition;
                    numberOfPartitions++;
                }
                else
                {
                    if (previousLargestElementInPartition > nextElementInPartition)
                    {
                        numberOfPartitions = 1;
                    }
                    else
                    {
                        numberOfPartitions += 1;
                    }
                }
            }

            return numberOfPartitions;
        }
    }
}
