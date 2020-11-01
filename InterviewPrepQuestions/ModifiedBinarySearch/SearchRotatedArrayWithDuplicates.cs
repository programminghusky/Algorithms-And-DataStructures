/* search in a sorted and rotated array that also has duplicates */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.ModifiedBinarySearch
{
    class SearchRotatedArrayWithDuplicates
    {
        public bool Search(int[] nums, int target)
        {
            int start = 0, end = nums.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target)
                    return true;

                if((nums[start] == nums[mid]) && (nums[end] == nums[mid]))
                {
                    ++start;
                    --end;
                }
                else if (nums[start] <= nums[mid])
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
            return false;
        }
    }
}
