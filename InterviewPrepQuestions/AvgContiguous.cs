/* Given an array, find the average of all contiguous subarrays of size ‘K’ in it. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions
{
    class AvgContiguous
    {
        public double[] FindAverages(int K, int[] arr)
        {
            double[] result = new double[arr.Length - K + 1];
            int resultIndex = 0;
            double sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if(i >= K-1)
                {
                    result[resultIndex] = sum / K;
                    sum -= arr[resultIndex];
                    resultIndex++;
                }
            }
            return result;
        }
    }
}
