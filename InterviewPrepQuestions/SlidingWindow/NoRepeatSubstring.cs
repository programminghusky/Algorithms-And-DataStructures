using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.SlidingWindow
{
    class NoRepeatSubstring
    {
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
