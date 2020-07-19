/* Any number will be called a happy number if, after repeatedly replacing it with a number 
 * equal to the sum of the square of all of its digits, leads us to number ‘1’. 
 * All other (not-happy) numbers will never reach ‘1’. 
 * Instead, they will be stuck in a cycle of numbers which does not include ‘1’. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.FastAndSlowPointers
{
    class HappyNumber
    {
        public bool Find(int num)
        {
            int slow = num, fast = num;
            do
            {
                slow = FindSumSquareDigits(slow);
                fast = FindSumSquareDigits(fast);
                fast = FindSumSquareDigits(fast);
            }while(slow != fast);
            return slow == 1;
        }

        private int FindSumSquareDigits(int num)
        {
            int sum = 0;
            int digit = 0;
            while(num != 0)
            {
                digit = num % 10;
                sum = sum + (digit * digit );
                num = num / 10;
            }
            return sum;
        }
    }
}
