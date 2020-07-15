/* find the maximum sum of any contiguous subarray of size ‘k’ */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions
{
    class MaxSumContiguous
    {
        public static int findMaxSumSubArray(int k, int[] arr)
        {
            int maxSum = arr[0];
            int sum = 0, index = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if(i >= k-1)
                {
                    //check and update maxSum
                    if (sum > maxSum)
                        maxSum = sum;
                    sum -= arr[index];
                    index++;
                }
            }
            return maxSum;
        }
    }
}
