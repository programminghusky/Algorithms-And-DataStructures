/* Given an array containing 0s, 1s and 2s, sort the array in-place.
 * You should treat numbers of the array as objects, hence, we can’t count 0s, 1s, and 2s to recreate the array. 
 * The flag of the Netherlands consists of three colors: red, white and blue; 
 * and since our input array also consists of three different numbers that is why it is called Dutch National Flag problem. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TwoPointers
{
    class DutchNationalFlag
    {
        public void SortColors(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            for(int i = 0; i <= right;)
            {
                if(nums[i] == 0)
                {
                    Swap(nums, i, left);
                    left++;
                    i++;
                }
                else if( nums[i] == 1)
                {
                    i++;
                }
                else
                {
                    Swap(nums, i, right);
                    right--;
                }
            }
        }

        private static void Swap(int[] arr, int i , int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
