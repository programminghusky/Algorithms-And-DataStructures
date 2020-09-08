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
    //Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
   // Output: [[1,6],[8,10],[15,18]]
    class MergeOverlappingIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length < 2)
                return intervals;
            Array.Sort(intervals, new ArrayComparer());

            int start = int.MaxValue;
            int end = 0;
            List<int[]> result = new List<int[]>();
            int count = intervals.Length;

            for(int i = 0; i< count;i++)
            {
                start = Math.Min(start, intervals[i][0]);
                end = Math.Max(end, intervals[i][1]);
                if(i == count - 1 || end < intervals[i + 1][0])
                {
                    result.Add(new int[2] { start, end });
                    start = int.MaxValue;
                    end = 0;
                }
            }
            return result.ToArray();
        }
    }
}
