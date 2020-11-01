/* Given a Bitonic array, find if a given ‘key’ is present in it. An array is considered bitonic if it is monotonically 
 * increasing and then monotonically decreasing. Monotonically increasing or decreasing means that for any index i in the 
 * array arr[i] != arr[i+1].Write a function to return the index of the ‘key’. If the ‘key’ is not present, return -1.  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.ModifiedBinarySearch
{
    class SearchBitonicArraycs
    {
        public static int search(int[] arr, int key)
        {
            int maxIndex = FindMax(arr);
            int keyIndex = BinarySearch(arr, key, 0, maxIndex);
            if (keyIndex != -1)
                return keyIndex;
            return BinarySearch(arr, key, maxIndex + 1, arr.Length - 1);
        }


        // find index of the maximum value in a bitonic array
        public static int FindMax(int[] arr)
        {
            int start = 0, end = arr.Length - 1;
            while (start < end)
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
            // at the end of the while loop, 'start == end'
            return start;
        }


        //Binary Search
        private static int BinarySearch(int[] arr, int key, int start, int end)
        {
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (key == arr[mid])
                    return mid;

                if (arr[start] < arr[end])
                { // ascending order
                    if (key < arr[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    { // key > arr[mid]
                        start = mid + 1;
                    }
                }
                else
                { // descending order        
                    if (key > arr[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    { // key < arr[mid]
                        start = mid + 1;
                    }
                }
            }
            return -1; // element is not found
        }
    }
}
