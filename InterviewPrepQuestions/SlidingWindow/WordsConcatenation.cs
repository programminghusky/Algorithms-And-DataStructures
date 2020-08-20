using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.SlidingWindow
{
    class WordsConcatenation
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            Dictionary<string, int> wordFreqMap = new Dictionary<string, int>();
            foreach(string word in words)
            {
                if(wordFreqMap.ContainsKey(word))
                {
                    wordFreqMap[word]++;
                }
                else
                {
                    wordFreqMap.Add(word, 1);
                }
            }

            IList<int> indices = new List<int>();
            int wordsCount = words.Length;
            if (wordsCount < 1)
                return indices;
            int eachWordLength = words[0].Length;

            for(int i = 0; i <= s.Length - (wordsCount * eachWordLength); i++)
            {
                Dictionary<string, int> seen = new Dictionary<string, int>();

                for(int j = 0; j < wordsCount; j++)
                {
                    int nextWordIndex = i+ (j * eachWordLength);
                    string word = s.Substring(nextWordIndex, eachWordLength);

                    if (!wordFreqMap.ContainsKey(word))
                        break;
                    if (seen.ContainsKey(word))
                        seen[word]++;
                    else
                        seen.Add(word, 1);

                    if (seen[word] > wordFreqMap[word])
                        break;

                    if ((j + 1) == wordsCount)
                        indices.Add(i);
                }
            }
            return indices;
        }
    }
}
