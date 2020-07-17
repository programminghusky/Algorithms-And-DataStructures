using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.BitwiseXOR
{
    class MissingNumber
    {
        public int FindMissingNumber(int[] arr)
        {
            int n = arr.Length;
            int xor = 0;
            for (int i = 0; i < n ; i++)
            {
                int missNum = i + 1;
                xor = xor ^ arr[i] ^ missNum;
            }

            xor = xor ^ (n + 1);
            return xor;
        }
    }
}
