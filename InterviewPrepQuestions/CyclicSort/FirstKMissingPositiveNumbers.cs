/*Given an unsorted array containing numbers and a number ‘k’, find the first ‘k’ missing positive numbers in the array.  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.CyclicSort
{
    class FirstKMissingPositiveNumbers
    {
        public List<int> FindNumbers(int[] nums, int k)
        {
            int i = 0;
            while (i < nums.Length)
            {
                if (nums[i] > 0 && nums[i] <= nums.Length && nums[i] != nums[nums[i] - 1])
                    Swap(nums, i, nums[i] - 1);
                else
                    i++;
            }

            List<int> missingNumbers = new List<int>();
            HashSet<int> extraNumbers = new HashSet<int>();
            for(i = 0; i < nums.Length && missingNumbers.Count < k; i++)
            {
                if (nums[i] != i + 1)
                {
                    missingNumbers.Add(i + 1);
                    extraNumbers.Add(nums[i]);
                }
            }

            for(i = 1; missingNumbers.Count < k; i++)
            {
                int candidateNumber = i + nums.Length;
                if(!extraNumbers.Contains(candidateNumber))
                {
                    missingNumbers.Add(candidateNumber);
                }
            }
            return missingNumbers;
        }

        private void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
