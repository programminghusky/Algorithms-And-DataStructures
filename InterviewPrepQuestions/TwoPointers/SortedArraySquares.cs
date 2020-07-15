/* Given a sorted array, create a new array containing squares of all the number of the input array in the sorted order. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TwoPointers
{
    class SortedArraySquares
    {
        public int[] MakeSquares(int[] arr)
        {
            int[] squares = new int[arr.Length];
            int left = 0, right = arr.Length - 1;
            int index = arr.Length - 1;
            while(left <= right)
            {
                int leftSquare = arr[left] * arr[left];
                int rightSquare = arr[right] * arr[right];
                if(leftSquare > rightSquare)
                {
                    squares[index] = leftSquare;
                    left++;
                    index--;
                }
                else
                {
                    squares[index] = rightSquare;
                    right--;
                    index--;
                }
            }
            return squares;
        }
    }
}
