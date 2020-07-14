/* Given a string, find the length of the longest substring in it with no more than K distinct characters.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions
{
    class LongestSubstringKDistinctChars
    {
        public int FindLength(String str, int k)
        {
            if (str == null || str.Length ==0 || str.Length < k)
                throw new Exception();

            int maxLength = 0, windowStart = 0;
            Dictionary<char, int> freqMap = new Dictionary<char, int>();

            for(int i = 0; i < str.Length; i++)
            {
                char rightChar = str[i];
                if (!freqMap.ContainsKey(rightChar))
                    freqMap.Add(rightChar, 1);
                else
                    freqMap[rightChar]++; // updates the freqMap
                
                while(freqMap.Count > k)
                {
                    //decrease frequency and slide window
                    freqMap[str[windowStart]]--;
                    if (freqMap[str[windowStart]] == 0)
                        freqMap.Remove(str[windowStart]);

                    windowStart++;
                }

                maxLength = Math.Max(maxLength, i - windowStart + 1);
            }

            return maxLength;
        }
    }
}
