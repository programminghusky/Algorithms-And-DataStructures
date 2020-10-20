/* Given an array of numbers sorted in ascending order, find the element in the array that has the minimum difference
 * with the given ‘key’. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.ModifiedBinarySearch
{
    class MinimumDifferenceElement
    {
        public static int SearchMinDiffElement(int[] arr, int key)
        {
            if (key < arr[0])
                return arr[0];
            if (key > arr[arr.Length - 1])
                return arr[arr.Length - 1];

            int start = 0, end = arr.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (key < arr[mid])
                    end = mid - 1;
                else if (key > arr[mid])
                    start = mid + 1;
                else
                    return mid;
            }

            if ((arr[start] - key) < (key - arr[end]))
                return arr[start];
            else
                return arr[end];
        }
    }
}
