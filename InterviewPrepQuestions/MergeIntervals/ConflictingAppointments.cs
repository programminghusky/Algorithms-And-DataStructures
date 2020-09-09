/* Given an array of intervals representing ‘N’ appointments, find out if a person can attend all the appointments. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.MergeIntervals
{
    class ConflictingAppointments
    {
        public bool CanAttendMeetings(int[][] intervals)
        {
            Array.Sort(intervals, new ArrayComparer());
            for (int i = 0; i < intervals.Length - 1; i++)
            {
                if (intervals[i][1] > intervals[i + 1][0])
                    return false;
            }
            return true;
        }

        class ArrayComparer : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                return x[0] - y[0];
            }
        }
    }
}
