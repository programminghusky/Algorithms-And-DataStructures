/* Given an array of positive numbers and a positive number ‘S’, 
 * find the length of the smallest contiguous subarray whose sum is greater than or equal to ‘S’. 
 * Return 0, if no such subarray exists.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions
{
    class SmallestSubarraySum
    {
        public int FindMinSubArray(int S, int[] arr)
        {
            int minLength = int.MaxValue;
            int windowStart = 0;
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                while(sum >= S) // record length at this point and slide the window ahead
                {
                    minLength = Math.Min(minLength, i - windowStart + 1 );
                    sum -= arr[windowStart];
                    windowStart++;
                }
            }
            return minLength;
        }
    }
}
