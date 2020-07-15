/* Given an array of characters where each character represents a fruit tree,
 * you are given two baskets and your goal is to put maximum number of fruits in each basket. 
 * The only restriction is that each basket can have only one type of fruit.
 * You can start with any tree, but once you have started you can’t skip a tree. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions
{
    class FruitsInToBaskets
    {
        public int FindLength(char[] arr)
        {
            int maxCount = 0, windowStart = 0;
            Dictionary<char, int> freqMap = new Dictionary<char, int>();

            for(int i = 0; i < arr.Length;i++)
            {
                if (!freqMap.ContainsKey(arr[i]))
                    freqMap.Add(arr[i], 1);
                else
                    freqMap[arr[i]]++;

                while(freqMap.Count > 2)
                {
                    freqMap[arr[windowStart]]--;
                    if (freqMap[arr[windowStart]] == 0)
                        freqMap.Remove(arr[windowStart]);
                    windowStart++;
                }
                maxCount = Math.Max(maxCount, i - windowStart + 1);
            }
            return maxCount;
        }
    }
}
