/* We are given an unsorted array containing ‘n’ numbers taken from the range 1 to ‘n’. The array has some numbers 
 * appearing twice, find all these duplicate numbers without using any extra space. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.CyclicSort
{
    class FindAllDuplicateNumbers
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            int i = 0;
            while(i < nums.Length)
            {
                if (nums[i] != nums[nums[i] - 1])
                    Swap(nums, i, nums[i] - 1);
                else
                    i++;
            }

            IList<int> duplicates = new List<int>();
            for(int j = 0; j< nums.Length;j++)
            {
                if(j+1 != nums[j])
                {
                    duplicates.Add(nums[j]);
                }
            }
            return duplicates;
        }

        private void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
