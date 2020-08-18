/* Given a string and a pattern, find all anagrams of the pattern in the given string. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.SlidingWindow
{
    class StringAnagrams
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            IList<int> indices = new List<int>();
            int windowStart = 0, matched = 0;
            Dictionary<char, int> charFreqMap = new Dictionary<char, int>();
            foreach (char ch in p)
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

                if(charFreqMap.ContainsKey(rightChar))
                {
                    charFreqMap[rightChar]--;
                    if (charFreqMap[rightChar] == 0)
                        matched++;
                }

                if (matched == charFreqMap.Count)
                    indices.Add(windowStart);

                if(i >= p.Length - 1)
                {
                    char leftChar = s[windowStart];
                    windowStart++;

                    if(charFreqMap.ContainsKey(leftChar))
                    {
                        if (charFreqMap[leftChar] == 0)
                            matched--;

                        charFreqMap[leftChar]++;
                    }
                }
            }
            return indices;
        }
    }
}
