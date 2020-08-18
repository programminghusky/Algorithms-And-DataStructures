/* Given a string and a pattern, find out if the string contains any permutation of the pattern. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.SlidingWindow
{
    class StringPermutation
    {
        public bool CheckInclusion(string s1, string s2)
        {
            int windowStart = 0, matched = 0;

            Dictionary<char, int> charFreqMap = new Dictionary<char, int>();
            foreach(char ch in s1)
            {
                if(charFreqMap.ContainsKey(ch))
                {
                    charFreqMap[ch]++;
                }
                else
                {
                    charFreqMap.Add(ch, 1);
                }
            }

            for(int i = 0; i < s2.Length; i++)
            {
                char rightChar = s2[i];
                if(charFreqMap.ContainsKey(rightChar))
                {
                    charFreqMap[rightChar]--;
                }
                if (charFreqMap[rightChar] == 0)
                {
                    matched++;
                }

                if(matched == charFreqMap.Count)
                {
                    return true;
                }

                if(i >= s1.Length - 1)
                {
                    char leftChar = s2[windowStart];
                    windowStart++;
                    if(charFreqMap.ContainsKey(leftChar))
                    {
                        if (charFreqMap[leftChar] == 0)
                            matched--;

                        charFreqMap[leftChar]++;
                    }
                }
            }
            return false;
        }
    }
}
