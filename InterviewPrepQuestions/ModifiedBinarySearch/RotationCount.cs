/* Given an array of numbers which is sorted in ascending order and is rotated ‘k’ times around a pivot, find ‘k’.
You can assume that the array does not have any duplicates. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.ModifiedBinarySearch
{
    class RotationCount
    {
        public static int countRotations(int[] arr)
        {
            int start = 0, end = arr.Length - 1;
            while (start < end)
            {
                int mid = start + (end - start) / 2;

                if (mid < end && arr[mid] > arr[mid + 1]) // if mid is greater than the next element
                    return mid + 1;
                if (mid > start && arr[mid - 1] > arr[mid]) // if mid is smaller than the previous element
                    return mid;

                if (arr[start] < arr[mid])
                { // left side is sorted, so the pivot is on right side
                    start = mid + 1;
                }
                else
                { // right side is sorted, so the pivot is on the left side     
                    end = mid - 1;
                }
            }

            return 0; // the array has not been rotated
        }
    }
}
