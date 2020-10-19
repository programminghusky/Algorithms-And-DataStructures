/* Given an array of numbers sorted in ascending order, find the floor of a given number ‘key’. The floor of the ‘key’ 
 * will be the biggest element in the given array smaller than or equal to the ‘key’
Write a function to return the index of the floor of the ‘key’. If there isn’t a floor, return -1.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.ModifiedBinarySearch
{
    class FloorOfANumber
    {
        public int SearchFloorOfANumber(int[] arr, int key)
        {
            if (key < arr[0])
                return -1;

            int start = 0, end = arr.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (key < arr[mid])
                    end = mid - 1;
                else if (key > arr[mid])
                    start = mid + 1;
                else
                    return mid;
            }
            return end;
        }
    }
}
