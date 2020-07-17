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

            BitwiseXOR.MissingSingleNumber num = new BitwiseXOR.MissingSingleNumber();
            var n = num.SingleNumber(new int[] { 1, 4, 2, 1, 3, 2, 3 });
            Console.ReadLine();
        }
    }
}
