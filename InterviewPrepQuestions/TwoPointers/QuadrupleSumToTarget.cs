/* Given an array of unsorted numbers and a target number, find all unique quadruplets in it, whose sum is equal to the target number. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TwoPointers
{
    class QuadrupleSumToTarget
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            IList<IList<int>> quadruplets = new List<IList<int>>();

            for(int i = 0; i < nums.Length - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                for(int j = i +1; j < nums.Length - 2; j++ )
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                        continue;
                    SearchPairs(nums, target, i, j, quadruplets);
                }
            }
            return quadruplets;
        }

        private static void SearchPairs(int[] nums, int target, int first, int second, IList<IList<int>> quadruplets)
        {
            int left = second + 1;
            int right = nums.Length - 1;
            
            while(left < right)
            {
                int sum = nums[first] + nums[second] + nums[left] + nums[right];
                if(sum == target)
                {
                    List<int> intList = new List<int>();
                    intList.Add(nums[first]);  intList.Add(nums[second]);  intList.Add(nums[left]);  intList.Add(nums[right]);
                    quadruplets.Add(intList);
                    left++;
                    right--;
                    while (left < right && nums[left] == nums[left - 1])
                        left++;
                    while (left < right && nums[right] == nums[right + 1])
                        right--;
                }
                else if( sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }
    }
}
