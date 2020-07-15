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
            TwoPointers.PairWithTargetSum pair = new TwoPointers.PairWithTargetSum();
            var arr = pair.Search(new int[] { 3,2,4 }, 6);
            Console.ReadLine();
        }
    }
}
