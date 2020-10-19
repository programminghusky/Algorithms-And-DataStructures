/* Given an array of numbers sorted in an ascending order, find the ceiling of a given number ‘key’. 
 * The ceiling of the ‘key’ will be the smallest element in the given array greater than or equal to the ‘key’.
Write a function to return the index of the ceiling of the ‘key’. If there isn’t any ceiling return -1.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.ModifiedBinarySearch
{
    class CeilingOfANumber
    {
        public int SearchCeilingOfANumber(int[] arr, int key)
        {
            //if the the is greater than the last element in the array
            if (key > arr[arr.Length - 1])
                return -1;

            int start = 0, end = arr.Length - 1;

            while(start <= end)
            {
                int mid = start + (end - start) / 2;
                if (key < arr[mid])
                    end = mid - 1;
                else if (key > arr[mid])
                    start = mid + 1;
                else
                    return mid;
            }
            return start;
        }
    }
}
