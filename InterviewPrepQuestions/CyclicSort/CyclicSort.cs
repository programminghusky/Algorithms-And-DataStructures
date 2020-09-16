/*Write a function to sort the integer array in-place in O(n)and without any extra space. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.CyclicSort
{
    class CyclicSort
    {
        public void Sort(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                while(nums[i] != i + 1)
                {
                    //Swap with
                    Swap(nums, i, nums[i] - 1);
                }
            }
        }

        private void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
