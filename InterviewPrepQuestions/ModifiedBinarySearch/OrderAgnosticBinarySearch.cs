/* Given a sorted array of numbers, find if a given number ‘key’ is present in the array. Though we know that the array is sorted,
 * we don’t know if it’s sorted in ascending or descending order. You should assume that the array can have duplicates.
Write a function to return the index of the ‘key’ if it is present in the array, otherwise return -1. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.ModifiedBinarySearch
{
    class OrderAgnosticBinarySearch
    {
        public int Search(int[] nums, int target)
        {
            int start = 0, end = nums.Length - 1;
            bool isAscending = nums[start] < nums[end];

            while(start <= end)
            {
                int mid = start + (end - start) / 2;
                if (target == nums[mid])
                    return mid;

                if(isAscending)
                {
                    if (target < nums[mid])
                        end = mid - 1;
                    else
                        start = mid + 1;
                }
                else
                {
                    if (target > nums[mid])
                        end = mid - 1;
                    else
                        start = mid + 1;
                }
            }

            return -1;
        }
    }
}
