/* We are given an unsorted array containing ‘n+1’ numbers taken from the range 1 to ‘n’. 
 * The array has only one duplicate but it can be repeated multiple times. Find that duplicate number without using any extra space.
 * You are, however, allowed to modify the input array.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.CyclicSort
{
    class FindDuplicateNumber
    {
        public int FindDuplicate(int[] nums)
        {
            int i = 0;
            while (i < nums.Length)
            {
                if (nums[i] != i + 1)
                {
                    if (nums[i] != nums[nums[i] - 1])
                        Swap(nums, i, nums[i] - 1);
                    else
                        return nums[i];
                }
                else
                {
                    i++;
                }
            }
            return -1;
        }

        private void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
