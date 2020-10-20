/* Given an infinite sorted array (or an array with unknown size), find if a given number ‘key’ is present in the array.
 * Write a function to return the index of the ‘key’ if it is present in the array, otherwise return -1.
 * 
 * Since it is not possible to define an array with infinite (unknown) size, you will be provided with an 
 * interface ArrayReader to read elements of the array. ArrayReader.get(index) will return the number at index; 
 * if the array’s size is smaller than the index, it will return Integer.MAX_VALUE.  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.ModifiedBinarySearch
{
    // Ignore the implementation of ArrayReader. This is outside the scope of this question
    class ArrayReader
    {
        int[] arr;
        ArrayReader(int[] arr)
        {
            this.arr = arr;
        }
        public int Get(int index)
        {
            if (index >= arr.Length)
                return int.MaxValue;
            return arr[index];
        }
    }
    class SearchInASortedInfiniteArray
    {
        public int Search(ArrayReader reader, int target)
        {
            int start = 0, end = 1;
            while(reader.Get(end) < target)
            {
                int newStart = end + 1;
                end += (end - start + 1) * 2;
                start = newStart;
            }
            return BinarySearch(reader, target, start, end);
        }

        private static int BinarySearch(ArrayReader reader, int key, int start, int end)
        {
            while(start <= end)
            {
                int mid = start + (end - start) / 2;
                if (key < reader.Get(mid))
                    end = mid - 1;
                else if (key > reader.Get(mid))
                    start = mid + 1;
                else
                    return mid;
            }
            return - 1;
        }
    }
}
