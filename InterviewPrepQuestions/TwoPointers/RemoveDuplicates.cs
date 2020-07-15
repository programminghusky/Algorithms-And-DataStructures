using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TwoPointers
{
    class RemoveDuplicates
    {
        public int Remove(int[] arr)
        {
            if (arr.Length < 1)
                return 0;
            int nextNonDuplicate = 1;
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[nextNonDuplicate-1] != arr[i])
                {
                    arr[nextNonDuplicate] = arr[i];
                    nextNonDuplicate++;
                }
            }
            return nextNonDuplicate;
        }
    }
}
