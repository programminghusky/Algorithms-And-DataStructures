/* Given an array of sorted numbers and a target sum, find a pair in the array whose sum is equal to the given target. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TwoPointers
{
    class PairWithTargetSum
    {
        public int[] Search(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            while(left < right)
            {
                if ((nums[left] + nums[right]) == target)
                    return new int[] { left, right };
                else if ((nums[left] + nums[right]) < target)
                    left++;
                else
                    right--;
            }
            return new int[] { -1, -1 };
        }
    }
}
