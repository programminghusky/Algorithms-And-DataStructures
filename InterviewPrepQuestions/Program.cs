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
            AvgContiguous avgContiguous = new AvgContiguous();
            double[] result = avgContiguous.FindAverages(5, new int[] { 1, 3, 2, 6, -1, 4, 1, 8, 2 });
            Console.ReadLine();
        }
    }
}
