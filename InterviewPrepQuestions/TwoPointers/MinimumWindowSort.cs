/* Given an array, find the length of the smallest subarray in it which when sorted will sort the whole array. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TwoPointers
{
    class MinimumWindowSort
    {
        public int FindUnsortedSubarray(int[] nums)
        {
            int low = 0, high = nums.Length - 1;

            while (low < nums.Length-1 && nums[low] <= nums[low + 1])
                low++;

            if (low == nums.Length - 1)
                return 0;

            while (high > 0 && nums[high] >= nums[high - 1])
                high--;

            int arrayMax = int.MinValue, arrayMin = int.MaxValue;

            for(int i = low; i<= high; i++)
            {
                arrayMax = Math.Max(arrayMax, nums[i]);
                arrayMin = Math.Min(arrayMin, nums[i]);
            }

            while (low > 0 && nums[low - 1] > arrayMin)
                low--;

            while (high < nums.Length - 1 && nums[high + 1] < arrayMax)
                high++;
            return high - low + 1;

        }
    }
}
