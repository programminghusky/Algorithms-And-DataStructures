/* Given an unsorted array containing numbers, find the smallest missing positive number in it. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.CyclicSort
{
    class SmallestMissingPositive
    {
        public int FirstMissingPositive(int[] nums)
        {
            int i = 0;
            while (i < nums.Length)
            {
                if (nums[i] > 0 && nums[i] <= nums.Length && nums[i] != nums[nums[i] - 1])
                    Swap(nums, i, nums[i] - 1);
                else
                    i++;
            }
            for (i = 0; i < nums.Length; i++)
                if (nums[i] != i + 1)
                    return i + 1;

            return nums.Length + 1;
        }

        private void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
