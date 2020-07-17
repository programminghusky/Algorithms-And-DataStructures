/* In a non-empty array of integers, every number appears twice except for one, find that single number. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.BitwiseXOR
{
    class MissingSingleNumber
    {
        public int SingleNumber(int[] nums)
        {
            int xor = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                xor = xor ^ nums[i];
            }
            return xor;
        }
    }
}
