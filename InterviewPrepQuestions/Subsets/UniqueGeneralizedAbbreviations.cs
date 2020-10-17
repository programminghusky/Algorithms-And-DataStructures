/* Given a word, write a function to generate all of its unique generalized abbreviations */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.Subsets
{
    class UniqueGeneralizedAbbreviations
    {
        public IList<string> GenerateAbbreviations(string word)
        {
            IList<string> result = new List<string>();
            int wordLen = word.Length;
            Queue<AbbreviatedWord> queue = new Queue<AbbreviatedWord>();
            queue.Enqueue(new AbbreviatedWord(new StringBuilder(), 0, 0));
            while(queue.Count !=0)
            {
                AbbreviatedWord abWord = queue.Dequeue();
                if(abWord.Start == wordLen)
                {
                    if (abWord.Count != 0)
                        abWord.Str.Append(abWord.Count);
                    result.Add(abWord.Str.ToString());
                }
                else
                {
                    queue.Enqueue(new AbbreviatedWord(new StringBuilder(abWord.Str.ToString()), abWord.Start + 1, abWord.Count + 1));

                    if (abWord.Count != 0)
                        abWord.Str.Append(abWord.Count);
                    queue.Enqueue(new AbbreviatedWord(new StringBuilder(abWord.Str.ToString()).Append(word[abWord.Start]), abWord.Start + 1, 0));
                }
            }
            return result;
        }
    }

    class AbbreviatedWord
    {
       public StringBuilder Str;
       public int Start;
       public int Count;

        public AbbreviatedWord(StringBuilder str, int start, int count)
        {
            Str = str;
            Start = start;
            Count = count;
        }
    
    }
}
