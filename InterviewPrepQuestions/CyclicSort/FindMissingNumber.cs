/* We are given an array containing ‘n’ distinct numbers taken from the range 0 to ‘n’.
 * Since the array has only ‘n’ numbers out of the total ‘n+1’ numbers, find the missing number.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.CyclicSort
{
    class FindMissingNumber
    {
        public int FindMissingNum(int[] nums)
        {
            int i = 0;
            while(i < nums.Length)
            {
                if (nums[i] < nums.Length && nums[i] != nums[nums[i]])
                    Swap(nums, i, nums[i]);
                else
                    i++;
            }
            // the first number that is out of place is returned
            for(i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i)
                    return i;
            }
            return nums.Length;
        }

        private void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
