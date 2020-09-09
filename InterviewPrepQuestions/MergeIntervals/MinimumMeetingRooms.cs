/* Given a list of intervals representing the start and end time of ‘N’ meetings,
 * find the minimum number of rooms required to hold all the meetings. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.MergeIntervals
{
    class MinimumMeetingRooms
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            if(intervals.Length == 0)
            {
                return 0;
            }
            Array.Sort(intervals, new ArrayComparer());

            // Sorted list represents collection of key/value pairs that are sorted by key based on the associated IComparer<T> implementation
            // Here we want to maintain sorted list/min heap by meetings end time. The reason we want to store by end time, it will tell
            // us what will be the first/latest meeting which will end from now.
            SortedList<int, int> sortedList = new SortedList<int, int>(new CustomHeapComparer());

            sortedList.Add(intervals[0][1], intervals[0][0]);
            for(int i = 1; i < intervals.Length; i++)
            {
                int currentIntervalStart = intervals[i][0];
                // This will give is the first element in sorted list(min heap). Remember we sort the SortedList by end time
                // so this is the min end after that everything will be greater
                int minHeapFirstEndingValue = sortedList.First().Key;

                // This is checking if current meeting's starting time, greater than min heaps first elements end time , that means
                // we can use existing room
                if(currentIntervalStart >= minHeapFirstEndingValue)
                {
                    sortedList.RemoveAt(0);
                }
                sortedList.Add(intervals[i][1], intervals[i][0]);
            }
            return sortedList.Count;
        }
    }

    class CustomHeapComparer: IComparer<int>
    {
        public int Compare(int a, int b)
        {
            int result = a.CompareTo(b);
            return result == 0 ? 1 : result;
        }
    }
}
