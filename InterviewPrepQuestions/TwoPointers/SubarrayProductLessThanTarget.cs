/* Given an array with positive numbers and a target number, find all of its contiguous subarrays 
 * whose product is less than the target number.   */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TwoPointers
{
    class SubarrayProductLessThanTarget
    {
        public List<List<int>> NumSubarrayProductLessThanTarget(int[] nums, int k)
        {
            List<List<int>> result = new List<List<int>>();
            int product = 1, windowStart = 0;
            for(int right = 0; right < nums.Length; right++)
            {
                product *= nums[right];
                while(product >= k && windowStart < nums.Length)
                {
                    product /= nums[windowStart];
                    windowStart++;
                }

                List<int> tempList = new List<int>();
                for(int i = right; i>=windowStart; i-- )
                {
                    tempList.Add(nums[i]);
                    result.Add(new List<int>(tempList));
                }
            }
            return result;
        }
    }
}
