/* Given a string and a pattern, find the smallest substring 
 * in the given string which has all the characters of the given pattern. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.SlidingWindow
{
    class SmallestWindowContainingSubstring
    {
        public string MinWindow(string s, string t)
        {
            int windowStart = 0, matched = 0;

            Dictionary<char, int> charFreqMap = new Dictionary<char, int>();
            foreach (char ch in t)
            {
                if (charFreqMap.ContainsKey(ch))
                {
                    charFreqMap[ch]++;
                }
                else
                {
                    charFreqMap.Add(ch, 1);
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                char rightChar = s[i];
                if (charFreqMap.ContainsKey(rightChar))
                {
                    charFreqMap[rightChar]--;

                    if (charFreqMap[rightChar] >= 0)
                    {
                        matched++;
                    }
                }

                if (matched == charFreqMap.Count)
                {
                    return true;
                }

                if (i >= t.Length - 1)
                {
                    char leftChar = s[windowStart];
                    windowStart++;
                    if (charFreqMap.ContainsKey(leftChar))
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
