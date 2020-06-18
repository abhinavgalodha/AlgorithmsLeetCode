using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class FourSum
    {
        /*
         * Given four lists A, B, C, D of integer values, compute how many tuples (i, j, k, l) there are such that A[i] + B[j] + C[k] + D[l] is zero.
           
           To make problem a bit easier, all A, B, C, D have same length of N where 0 ≤ N ≤ 500. All integers are in the range of -228 to 228 - 1 and the result is guaranteed to be at most 231 - 1.
           
           Example:
           
           Input:
           A = [ 1, 2]
           B = [-2,-1]
           C = [-1, 2]
           D = [ 0, 2]
           
           Output:
           2
           
           Explanation:
           The two tuples are:
           1. (0, 0, 0, 1) -> A[0] + B[0] + C[0] + D[1] = 1 + (-2) + (-1) + 2 = 0
           2. (1, 1, 0, 0) -> A[1] + B[1] + C[0] + D[0] = 2 + (-1) + (-1) + 0 = 0
           
         *
         *
         */

        public int FourSumCountUsingNaiveImplementation(int[] A, int[] B, int[] C, int[] D)
        {
            var result = 0;

            // Naive Solution O(N4)
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    for (int k = 0; k < C.Length; k++)
                    {
                        for (int l = 0; l < D.Length; l++)
                        {
                            if (A[i] + B[j] + C[k] + D[l] == 0)
                            {
                                result++;
                            }
                        }
                    }
                }
            }
            return result;
        }

        public int FourSumCountUsingOptimization1(int[] A, int[] B, int[] C, int[] D)
        {
            var result = 0;

            // Store element of the last Array in Hashet. This would be used for searching with O(1).
            var hashSetOfLastArrayElements = new HashSet<int>(D.Length);
            D.ToList().ForEach(x => hashSetOfLastArrayElements.Add(x));

            // Naive Solution O(N3)
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    for (int k = 0; k < C.Length; k++)
                    {
                        var currentSum = A[i] + B[j] + C[k];
                        var diff = 0 - currentSum;
                        if(hashSetOfLastArrayElements.Contains(diff))
                            result++;
                    }
                }
            }
            return result;
        }

        public int FourSumCountUsingHashSet(int[] A, int[] B, int[] C, int[] D)
        {
            var result = 0;

            var listOfAB = new HashSet<int>(A.Length);
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    listOfAB.Add(A[i] + B[j]);
                }
            }

            var listOfCD = new List<int>(A.Length);
            for (int i = 0; i < C.Length; i++)
            {
                for (int j = 0; j < D.Length; j++)
                {
                    var sumCD = C[i] + D[j];
                    if (listOfAB.Contains(-1 * sumCD))
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
