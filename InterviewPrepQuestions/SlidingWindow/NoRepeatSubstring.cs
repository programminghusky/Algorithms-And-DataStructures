using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.SlidingWindow
{
    class NoRepeatSubstring
    {
        public int LengthOfLongestSubstringOptimal(string s)
        {
            int maxLength = 0, windowStart = 0;
            Dictionary<char, int> charMap = new Dictionary<char, int>();
            for(int i = 0; i < s.Length; i++)
            {
                char rightChar = s[i];
                if(charMap.ContainsKey(rightChar))
                {
                    windowStart = Math.Max(windowStart,charMap[rightChar] + 1);
                }
                if (!charMap.ContainsKey(rightChar))
                {
                    charMap.Add(rightChar, i);
                }
                else
                {
                    charMap[rightChar] = i;
                }
                 maxLength = Math.Max(maxLength, i - windowStart + 1);               
            }
            return maxLength;
        }


        public int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0, index = 0, j = 0;
            HashSet<char> charSet = new HashSet<char>();

            while(j < s.Length)
            {
                if(! charSet.Contains(s[j]))
                {
                    charSet.Add(s[j]);
                    j++;
                    maxLength = Math.Max(maxLength, j - index);
                }
                else
                {
                    charSet.Remove(s[index]);
                    index++;
                }
            }
            return maxLength;
        }
            /* Brute Force 
            public int LengthOfLongestSubstring(string s)
            {
                string str = s[0] + "";
                int length = 1;
                int maxLength = int.MinValue;

                for(int i = 1; i < s.Length; i++)
                {
                    if(!str.Contains(s[i]))
                    {
                        str = str + s[i];
                        length++;
                        maxLength = Math.Max(length, maxLength);
                    }
                    else
                    {
                        while(str.Contains(s[i]))
                        {
                            str = str.Substring(1);
                            length--;
                        }
                        str = str + s[i];
                        length++;
                    }
                }
                return maxLength;
            }
            */
        }
}
