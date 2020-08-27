/* Given two strings containing backspaces (identified by the character ‘#’), check if the two strings are equal. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TwoPointers
{
    class StringsContainingBackspace
    {
        public bool BackspaceCompare(string S, string T)
        {
            int index1 = S.Length - 1;
            int index2 = T.Length - 1;

            while(index1 >=0 || index2 >=0)
            {
                int i1 = GetNextValidChar(S, index1);
                int i2 = GetNextValidChar(T, index2);

                if (i1 < 0 && i2 < 0)
                    return true;
                if (i1 < 0 || i2 < 0)
                    return false;
                if (S[i1] != T[i2])
                    return false;

                index1 = i1 - 1;
                index2 = i2 - 1;
            }

            return true;         
        }

        private static int GetNextValidChar(string str,int index)
        {
            int backSpaceCount = 0;
            while(index >= 0)
            {
                if (str[index] == '#')
                {
                    backSpaceCount++;
                }
                else if (backSpaceCount > 0)
                {
                    backSpaceCount--;
                }
                else
                {
                    break;
                }
                index--;
            }
            return index;
        }
    }
}
