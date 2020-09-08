/* Given a list of non-overlapping intervals sorted by their start time, insert a given interval at the correct position 
 * and merge all necessary intervals to produce a list that has only mutually exclusive intervals. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.MergeIntervals
{
    class InsertInterval
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            if(intervals.Length == 0)
            {
                return new int[][] { newInterval };
            }

            List<int[]> result = new List<int[]>();

            foreach(var interval in intervals)
            {
                //new intervals start time is greater than the current intervals end time - > so add the current interval
                if(newInterval[0] > interval[1])
                {
                    result.Add(interval);
                }
                //new intervals end time is lesser than the current intervals start time
                else if(newInterval[1] < interval[0])
                {
                    result.Add(newInterval);
                    newInterval = interval;
                }
                else
                {
                    newInterval[0] = Math.Min(interval[0], newInterval[0]);
                    newInterval[1] = Math.Max(interval[1], newInterval[1]);
                }
            }
            result.Add(newInterval);
            return result.ToArray();
        }
    }
}
