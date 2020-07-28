/* Given an array containing 0s and 1s, if you are allowed to replace no more than ‘k’ 0s with 1s, 
 * find the length of the longest contiguous subarray having all 1s. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.SlidingWindow
{
    class LongestSubarrayWithOnesAfterReplacement
    {
        public int LongestOnes(int[] A, int K)
        {
            int windowStart = 0, maxLength = 0, maxOnesCount = 0;
            for(int i = 0; i < A.Length; i++)
            {
                if (A[i] == 1)
                    maxOnesCount++;
                if( i - windowStart + 1 - maxOnesCount > K)
                {
                    if (A[windowStart] == 1)
                        maxOnesCount--;
                    windowStart++;
                }
                maxLength = Math.Max(maxLength, i - windowStart + 1);
            }
            return maxLength;
        }
    }
}
