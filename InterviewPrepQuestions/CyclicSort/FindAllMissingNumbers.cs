/* We are given an unsorted array containing numbers taken from the range 1 to ‘n’. 
 * The array can have duplicates, which means some numbers will be missing. Find all those missing numbers. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.CyclicSort
{
    class FindAllMissingNumbers
    {
        public List<int> FindNumbers(int[] nums)
        {
            List<int> missing = new List<int>();
            int i = 0;
            while (i < nums.Length )
            {
                if (i + 1 != nums[i])
                    Swap(nums, i, nums[i] - 1);
                else
                    i++;
            }

            for(int j = 0; j< nums.Length;j++)
            {
                if (i + 1 != nums[i])
                    missing.Add(i + 1);
            }
            return missing;
        }

        private void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
