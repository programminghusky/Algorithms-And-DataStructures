/* For a given number ‘N’, write a function to generate all combination of ‘N’ pairs of balanced parentheses. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.Subsets
{
    class ParanthesesString
    {
        public string str;
        public int OpenCount;
        public int CloseCount;

        public ParanthesesString(string s, int openCount, int closeCount)
        {
            str = s;
            OpenCount = openCount;
            CloseCount = closeCount;
        }
    }
    class BalancedParantheses
    {
       
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> result = new List<string>();
            Queue<ParanthesesString> queue = new Queue<ParanthesesString>();
            queue.Enqueue(new ParanthesesString("", 0, 0));

            while(!(queue.Count == 0))
            {
                ParanthesesString ps = queue.Dequeue();
                //if the max open and close have been reached add it to the result
                if (ps.OpenCount == n && ps.CloseCount == n)
                {
                    result.Add(ps.str);
                }
                else
                {
                    if (ps.OpenCount < n)
                        queue.Enqueue(new ParanthesesString(ps.str + "(", ps.OpenCount + 1, ps.CloseCount));
                    if (ps.OpenCount > ps.CloseCount)
                        queue.Enqueue(new ParanthesesString(ps.str + ")", ps.OpenCount, ps.CloseCount + 1));
                }
            }
            return result;
        }
    }
}
