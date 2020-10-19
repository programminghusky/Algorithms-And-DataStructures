/* Given a list of sorted characters letters containing only lowercase letters, and given a target letter target,
 * find the smallest element in the list that is larger than the given target.
Letters also wrap around. For example, if the target is target = 'z' and letters = ['a', 'b'], the answer is 'a'.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.ModifiedBinarySearch
{
    class SmallestLetterGreaterThanTarget
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            int len = letters.Length;
            if ((target > letters[len - 1]) || (target < letters[0]))
                return letters[0];

            int start = 0, end = len - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (target < letters[mid])
                    end = mid - 1;
                else
                    start = mid + 1;            
            }
            return letters[start % len];
        }
    }
}
