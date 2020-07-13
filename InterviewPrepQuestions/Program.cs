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
            SmallestSubarraySum smallestSum = new SmallestSubarraySum();
            int result = smallestSum.FindMinSubArray(7, new int[] { 2, 1, 5, 2, 3, 2 });
            Console.ReadLine();
        }
    }
}
