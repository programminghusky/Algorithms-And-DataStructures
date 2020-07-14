using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            LongestSubstringKDistinctChars smallestSum = new LongestSubstringKDistinctChars();
            int result = smallestSum.FindLength("cbbebi", 3);
            Console.ReadLine();
        }
    }
}
