/* Given an array of numbers sorted in ascending order, find the range of a given number ‘key’. 
 * The range of the ‘key’ will be the first and last position of the ‘key’ in the array.
Write a function to return the range of the ‘key’. If the ‘key’ is not present return [-1, -1]. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.ModifiedBinarySearch
{
    class NumberRange
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int[] result = new int[] { -1, -1 };
            result[0] = Search(nums, target, false);
            if (result[0] != -1) //search only if key is present
                result[1] = Search(nums, target, true);

            return result;
        }

        public static int Search(int[] arr, int key, bool FindMaxIndex)
        {
            int keyIndex = -1;
            int start = 0, end = arr.Length - 1;
            while(start <= end)
            {
                int mid = start + (end - start) / 2;
                if (key < arr[mid])
                    end = mid - 1;
                else if (key > arr[mid])
                    start = mid + 1;
                else // when the match has been found key == arr[mid]
                {
                    keyIndex = mid;
                    if (FindMaxIndex)
                        start = mid + 1;
                    else
                        end = mid - 1;
                }
            }
            return keyIndex;
        }
    }
}
