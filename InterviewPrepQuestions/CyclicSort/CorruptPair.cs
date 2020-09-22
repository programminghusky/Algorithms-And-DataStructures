/*We are given an unsorted array containing ‘n’ numbers taken from the range 1 to ‘n’. 
 * The array originally contained all the numbers from 1 to ‘n’, but due to a data error,
 * one of the numbers got duplicated which also resulted in one number going missing. Find both these numbers.  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.CyclicSort
{
    class CorruptPair
    {
        public int[] FindNumbers(int[] nums)
        {
            int i = 0;
            while (i < nums.Length)
            {
                if (nums[i] != nums[nums[i] - 1])
                    Swap(nums, i, nums[i] - 1);
                else
                    i++;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                if (j + 1 != nums[j])
                {
                    return new int[] { nums[j], j+ 1 };
                }
            }
            return new int[] { -1, -1 };
        }

        private void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
