/* Given two lists of intervals, find the intersection of these two lists.
 * Each list consists of disjoint intervals sorted on their start time. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.MergeIntervals
{
    //Input: A = [[0,2],[5,10],[13,23],[24,25]], B = [[1,5],[8,12],[15,24],[25,26]]
    //Output: [[1,2],[5,5],[8,10],[15,23],[24,24],[25,25]]
    class IntervalsIntersection
    {
        public int[][] IntervalIntersection(int[][] A, int[][] B)
        {
            List<int[]> ans = new List<int[]>();
            int i = 0, j = 0;
            while (i < A.Length && j < B.Length)
            {
                int lo = Math.Max(A[i][0], B[j][0]);
                int hi = Math.Min(A[i][1], B[j][1]);
                if (lo <= hi)
                    ans.Add(new int[] { lo, hi });

                if (A[i][1] < B[j][1])
                    i++;
                else
                    j++;
            }
            return ans.ToArray();
        }
    }
}
