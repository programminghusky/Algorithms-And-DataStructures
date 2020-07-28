/* Given an array of unsorted numbers, find all unique triplets in it that add up to zero. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TwoPointers
{
    class TripletSumToZero
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> unique = new List<IList<int>>();
            Array.Sort(nums);
            for(int i = 0; i < nums.Length - 2; i++)
            {
                if ((i > 0) && nums[i] == nums[i - 1])
                    continue;

                SearchPair(nums, i , unique);
            }
            return unique;
        }

        private static void SearchPair(int[] arr, int index, IList<IList<int>> triplets)
        {
            int left = index + 1;
            int right = arr.Length - 1;

            while(left < right)
            {
                int sum = arr[index] + arr[left] + arr[right];
                if ((sum < 0) || (left > index + 1 && arr[left] == arr[left - 1]))
                {
                    left++;
                }
                else if ((sum > 0) || (right < arr.Length - 1 && arr[right] == arr[right + 1])) 
                {
                    right--;
                }
                else
                {
                    triplets.Add(new List<int>() { arr[index], arr[left], arr[right] });
                    left++;
                    right--;
                }
            }
        }
    }
}
