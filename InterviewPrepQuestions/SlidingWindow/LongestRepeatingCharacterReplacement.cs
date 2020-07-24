/* Given a string with lowercase letters only, if you are allowed to replace no more than ‘k’ letters with any letter,
 * find the length of the longest substring having the same letters after replacement.  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.SlidingWindow
{
    class LongestRepeatingCharacterReplacement
    {
        public int CharacterReplacement(string s, int k)
        {
            int windowStart = 0, maxLength = 0, maxRepeatLetterCount = 0;
            Dictionary<char, int> freqMap = new Dictionary<char, int>();
            for(int i = 0; i< s.Length; i++)
            {
                char rightChar = s[i];
                if(!freqMap.ContainsKey(rightChar))
                {
                    freqMap.Add(rightChar, 1);
                }
                else
                {
                    freqMap[rightChar]++;
                }
                maxRepeatLetterCount = Math.Max(maxRepeatLetterCount, freqMap[rightChar]);

                if(i - windowStart + 1 - maxRepeatLetterCount > k)
                {
                    char leftChar = s[windowStart];
                    freqMap[leftChar]--;
                    windowStart++;
                }
                maxLength = Math.Max(maxLength, i - windowStart + 1);
            }
            return maxLength;
        }
    }
}
