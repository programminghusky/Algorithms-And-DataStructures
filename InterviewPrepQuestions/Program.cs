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
            TwoPointers.RemoveDuplicates remove = new TwoPointers.RemoveDuplicates();
            var arr = remove.Remove(new int[] { 2, 3, 3, 3, 6, 9, 9 });
            Console.ReadLine();
        }
    }
}
