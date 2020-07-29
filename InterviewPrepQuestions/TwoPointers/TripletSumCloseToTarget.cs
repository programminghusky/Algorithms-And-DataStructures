/* Given an array nums of n integers and an integer target, find three integers in nums such that the sum is closest to target. 
 * Return the sum of the three integers. You may assume that each input would have exactly one solution. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TwoPointers
{
    class TripletSumCloseToTarget
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            if (nums == null || nums.Length < 3)
                throw new ArgumentException();

            int smallestDiff = int.MaxValue;
            Array.Sort(nums);

            for (int i = 0; i < nums.Length-2 ; i++)
            {
                int left = i + 1, right = nums.Length - 1;
                while(left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if(Math.Abs(target - sum) < Math.Abs(smallestDiff))
                    {
                        smallestDiff = target - sum;
                    }

                    if(sum < target )
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return target - smallestDiff;
        }
    }
}
