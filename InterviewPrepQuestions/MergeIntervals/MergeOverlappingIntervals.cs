/* Given a list of intervals, merge all the overlapping intervals to produce a list that has only mutually exclusive intervals. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.MergeIntervals
{
    class ArrayComparer : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            return x[0] - y[0];
        }
    }
    class MergeOverlappingIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length < 2)
                return intervals;
            Array.Sort(intervals, new ArrayComparer());

            return intervals;
        }
    }
}
