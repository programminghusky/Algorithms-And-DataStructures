/* Find the maximum value in a given Bitonic array. An array is considered bitonic if it is monotonically increasing and then 
 * monotonically decreasing. Monotonically increasing or decreasing means that for any index i in the array arr[i] != arr[i+1].*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.ModifiedBinarySearch
{
    class BitonicArrayMaximum
    {
        public static int FindMax(int[] arr)
        {
            int start = 0, end = arr.Length - 1;
            while(start < end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] > arr[mid + 1])
                {
                    end = mid;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return arr[start];
        }
    }
}
