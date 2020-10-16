/* Given a string S, we can transform every letter individually to be lowercase or uppercase to create another string.
Return a list of all possible strings we could create. You can return the output in any order. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.Subsets
{
    class StringPermutaionsChangingCase
    {
        public IList<string> LetterCasePermutation(string S)
        {
            IList<string> permutaions = new List<string>();
            if (S == null)
                return permutaions;

            permutaions.Add(S);

            for(int i = 0; i<S.Length;i++)
            {
                //process only if its a letter
                if(char.IsLetter(S[i]))
                {
                    int n = permutaions.Count;
                    for(int j = 0; j < n; j++)
                    {
                        char[] chs = permutaions[j].ToArray();
                        if(char.IsUpper(chs[i]))
                        {
                            chs[i] = char.ToLower(chs[i]);
                        }
                        else
                        {
                            chs[i] = char.ToUpper(chs[i]);
                        }
                        permutaions.Add(new string(chs));
                    }
                }
            }
            return permutaions;
        }
    }
}
