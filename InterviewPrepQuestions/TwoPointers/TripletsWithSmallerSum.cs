/* Given an array of n integers nums and a target, find the number of index triplets i, j, k with 0 <= i < j < k < n 
 * that satisfy the condition nums[i] + nums[j] + nums[k] < target. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TwoPointers
{
    class TripletsWithSmallerSum
    {
        public int ThreeSumSmaller(int[] nums, int target)
        {
            int count = 0, sum = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {

                    sum = nums[i] + nums[left] + nums[right];
                    if (sum < target)
                    {
                        count += right - left;
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return count;
        }
    }
}
