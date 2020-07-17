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
            //TwoPointers.SortedArraySquares sorted = new TwoPointers.SortedArraySquares();
            //var arr = sorted.MakeSquares(new int[] { -3, -1, 0, 1, 2 });

            BitwiseXOR.MissingNumber num = new BitwiseXOR.MissingNumber();
            var n = num.FindMissingNumber(new int[] { 1, 5, 2, 6, 4 });
            Console.ReadLine();
        }
    }
}
