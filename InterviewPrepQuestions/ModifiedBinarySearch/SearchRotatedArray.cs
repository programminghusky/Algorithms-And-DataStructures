/* Given an array of numbers which is sorted in ascending order and also rotated by some arbitrary number, 
 * find if a given ‘key’ is present in it. Write a function to return the index of the ‘key’ in the rotated array. 
 * If the ‘key’ is not present, return -1. You can assume that the given array does not have any duplicates.  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.ModifiedBinarySearch
{
    class SearchRotatedArray
    {
        public int Search(int[] nums, int target)
        {
            int start = 0, end = nums.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target)
                    return mid;

                if (nums[start] <= nums[mid])
                { // left side is sorted in ascending order
                    if (target >= nums[start] && target < nums[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    { //key > arr[mid]
                        start = mid + 1;
                    }
                }

                else
                { // right side is sorted in ascending order       
                    if (target > nums[mid] && target <= nums[end])
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }
            // we are not able to find the element in the given array
            return -1;
        }
    }
}
